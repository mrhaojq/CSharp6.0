using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace HttpClientSample
{
    class Program
    {

        private const string NorthwindUrl = "http://services.odata.org/Northwind/Northwind.svc/Regions";
        private const string IncorrectUrl = "http://services.odata.org/Northwind1/Northwind.svc/Regions";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //GetDataSimpleAsync().Wait();//Wait()等待任务完全执行
            // GetDataWithExceptionsAsync().Wait();
            //GetDataWithHeadersAsync().Wait();
            //GetDataWithMessageHandlerAsync().Wait();
            GetDataAdvancedAsync().Wait();
            ReadKey();
        }

        private static async Task GetDataSimpleAsync()
        {
            using (var client = new HttpClient())
            {
                //通过HttpClient 向NorthwindUrl 发送请求 用HttpResponseMessage接收反馈 包含 标题 状态 内容 的响应
                HttpResponseMessage response = await client.GetAsync(NorthwindUrl);//默认情况下不会抛出异常
                if (response.IsSuccessStatusCode)
                {
                    WriteLine($"Response Status Code:{(int)response.StatusCode} {response.ReasonPhrase}");
                    string responseBodyAsText = await response.Content.ReadAsStringAsync();
                    WriteLine($"Received payload of {responseBodyAsText.Length} characters");
                    WriteLine();
                    WriteLine(responseBodyAsText);
                }
            }
        }

        public static async Task GetDataWithExceptionsAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Accept", "application/json;odata=verbose");
                    HttpResponseMessage response = await client.GetAsync(IncorrectUrl);
                    ShowHeaders("Request Headers:", client.DefaultRequestHeaders);

                    response.EnsureSuccessStatusCode(); //检查IsSuccessStatusCode 是否是false 如果是fales抛出异常

                    ShowHeaders("Response Headers", response.Headers);

                    WriteLine($"Response Status Code:{(int)response.StatusCode} {response.ReasonPhrase}");
                    string responseBodyAsText = await response.Content.ReadAsStringAsync();
                    WriteLine($"Received payload of {responseBodyAsText.Length} characters");
                    WriteLine();
                    WriteLine(responseBodyAsText);
                }
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.Message}");
            }
        }

        public static async Task GetDataWithHeadersAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Accept", "application/json;odata=verbose");
                    ShowHeaders("Request Headers:", client.DefaultRequestHeaders);

                    HttpResponseMessage response = await client.GetAsync(NorthwindUrl);
                    response.EnsureSuccessStatusCode();

                    ShowHeaders("Response Headers:", response.Headers);

                    WriteLine($"Response Status Code: {(int)response.StatusCode} {response.ReasonPhrase}");
                    string responseBodyAsText = await response.Content.ReadAsStringAsync();
                    WriteLine($"Received payload of {responseBodyAsText.Length} characters");
                    WriteLine();
                    WriteLine(responseBodyAsText);

                }
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.Message}");
            }
        }

        private static void ShowHeaders(string title, HttpHeaders headers)//HttpHeaders
        {

            WriteLine(title);
            foreach (var header in headers)
            {
                string value = string.Join(" ", header.Value);
                WriteLine($"Header: {header.Key} Value:{value}");
            }
            WriteLine();
        }

        public static async Task GetDataWithMessageHandlerAsync()
        {
            try
            {
                using (var client = new HttpClient(new SampleMessageHandler("error")))//可以添加自定义处理管道
                {
                    HttpResponseMessage response = await client.GetAsync(NorthwindUrl);//
                    response.EnsureSuccessStatusCode();

                    WriteLine($"Response Status Code: {(int)response.StatusCode} {response.ReasonPhrase}");
                    string responseBodyAsText = await response.Content.ReadAsStringAsync();
                    WriteLine($"Received payload of {responseBodyAsText.Length} characters");
                    WriteLine();
                    WriteLine(responseBodyAsText);

                }
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.Message}");
            }
        }

        public static async Task GetDataAdvancedAsync()
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, NorthwindUrl);//请求信息
                HttpResponseMessage response = await client.SendAsync(request);//要用SendAsync  
               //HttpResponseMessage response = await client.GetAsync(NorthwindUrl);//在后台用的 是SendAsync 与上一句等效
                if (response.IsSuccessStatusCode)
                {
                    WriteLine($"Response Status Code:{(int)response.StatusCode} {response.ReasonPhrase}");
                    string responseBodyAsText = await response.Content.ReadAsStringAsync();
                    WriteLine($"Received payload of {responseBodyAsText.Length} characters");
                    WriteLine();
                    WriteLine(responseBodyAsText);
                }
            }
        }
    }
}
