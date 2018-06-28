using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HelloClient
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string Say(string name);
    }
}
