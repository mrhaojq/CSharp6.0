using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;
using static System.Console;

namespace HelloServiceHost
{
    public class MyHelloServiceHost : IDisposable
    {
        private ServiceHost _myHelloHost;
        public const string BaseAddress = @"net.pipe://localhost";
        public const string HelloServiceAddress = "Hello";//可选地址
        public static readonly Type ServiceType = typeof(HelloService.HelloService);//服务契约实现类型
        public static readonly Type ContractType = typeof(HelloService.IHelloService);//服务契约接口
        public static readonly Binding HelloBinding = new NetNamedPipeBinding();//服务定义一个绑定

        public MyHelloServiceHost()
        {
            CreateHelloServiceHost();
        }

        protected void CreateHelloServiceHost()
        {
            _myHelloHost = new ServiceHost(ServiceType, new Uri[] { new Uri(BaseAddress) });//创建服务对象
            _myHelloHost.AddServiceEndpoint(ContractType, HelloBinding, HelloServiceAddress);//添加终结点（绑定到那个服务契约接口） 
        }

        public void Open()
        {
            WriteLine($"开始启动服务...");
            _myHelloHost.Open();
            WriteLine($"服务已启动");
        }


        public void Dispose()
        {
            if (_myHelloHost != null)
            {
                (_myHelloHost as IDisposable).Dispose();
            }
        }
    }
}
