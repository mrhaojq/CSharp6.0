using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketsSample
{
    [ServiceContract]
    public interface IDemoCallback
    {
        [OperationContract(IsOneWay = true)]
        Task SendMessage(string message);
    }

    [ServiceContract(CallbackContract = typeof(IDemoCallback))]
    public interface IDemoService
    {
        [OperationContract]
        void StartSendingMessages();
    }
}
