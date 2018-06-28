using System;
using System.Net;
using static System.Console;

namespace Utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string url = @"http://news.ifeng.com/a/20180628/58916096_0.shtml?_zbs_firefox_gg";
            UriSample(url);

            WriteLine();
            WriteLine("IPAddressSample:");
            IPAddressSample("112.124.19.35");


            ReadKey();
        }

        /// <summary>
        /// 可以通过这种方式 解析/创建Url了
        /// </summary>
        /// <param name="url"></param>
        public static void UriSample(string url)
        {
            //URI 用于分析 组合 和 比较URI
            var page = new Uri(url);

            WriteLine($"schem:{page.Scheme}");

#if NET46
            WriteLine($"host: {page.Host}, type: {page.HostNameType}");
#else
            WriteLine($"host:{page.Host},type:{page.HostNameType},idn host:{page.IdnHost}");
#endif  

            WriteLine($"port:{page.Port}");

            WriteLine($"path:{page.AbsolutePath}");

            WriteLine($"AbsoluteUri:{page.AbsoluteUri}");

            WriteLine($"query:{page.Query}");

            foreach (var segment in page.Segments)
            {
                WriteLine($"segment:{segment}");
            }

            //UriBuilder 允许把给定的字符串当作Url的组成部分，从而构建一个Url
            var uriBuilder = new UriBuilder();
            uriBuilder.Host = "www.cninnovation.com";
            uriBuilder.Port = 80;
            uriBuilder.Path = "training/Mvc";
            Uri uri = uriBuilder.Uri;
            WriteLine($"UriBuilder:{uri}");
        }

        public static void IPAddressSample(string ipAddressString)
        {
            IPAddress address;

            if (!IPAddress.TryParse(ipAddressString,out address))
            {
                WriteLine($"cannot parse {ipAddressString}");
                return;
            }

            byte[] bytes = address.GetAddressBytes();
            for (int i = 0; i < bytes.Length; i++)
            {
                WriteLine($"byte {i}:{bytes[i]:X}");
            }

            WriteLine($"family {address.AddressFamily},map to ipv6:{address.MapToIPv6()},map to ipv4:{address.MapToIPv4()}");

            WriteLine();

            WriteLine($"IPv4 loopback address:{IPAddress.Loopback}");
            WriteLine($"IPv6 loopback address:{IPAddress.IPv6Loopback}");
            WriteLine($"IPv4 broadcast address:{IPAddress.Broadcast}");
            WriteLine($"IPv4 any address:{IPAddress.Any}");
            WriteLine($"IPv6 any address:{IPAddress.IPv6Any}");
        }
    }
}
