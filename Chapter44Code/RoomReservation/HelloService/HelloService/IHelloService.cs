using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HelloService
{
    [ServiceContract]//服务契约
    public interface IHelloService
    {
        [OperationContract]//操作契约
        string SayHello(string name);
    }
}
