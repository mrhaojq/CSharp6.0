using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloServiceHost;
using HelloService;
using System.ServiceModel;
using System.ServiceModel.Channels;


namespace HelloClient
{
    public class HelloProxy : ClientBase<IHelloService>, IService
    {
        public static readonly Binding HelloBinding = new NetNamedPipeBinding();
        public static readonly EndpointAddress HelloAddress = new EndpointAddress(new Uri("net.pipe://localhost/Hello"));

        public HelloProxy()
            : base(HelloBinding, HelloAddress)
        {

        }

        public string Say(string name)
        {
            return Channel.SayHello(name);
        }
    }
}
