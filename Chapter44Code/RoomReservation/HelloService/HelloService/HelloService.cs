using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloService
{
    public class HelloService : IHelloService
    {
        public string SayHello(string name)
        {
            return $"你好，我是：{name}";
        }
    }
}
