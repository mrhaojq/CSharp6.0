using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketsSample
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“DemoService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 DemoService.svc 或 DemoService.svc.cs，然后开始调试。
    public class DemoService : IDemoService
    {
        public void StartSendingMessages()
        {
            IDemoCallback callback = OperationContext.Current.GetCallbackChannel<IDemoCallback>();
            Task.Run(() => BackgroundSender(callback));
        }

        private async Task BackgroundSender(IDemoCallback callback)
        {
            int loop = 0;
            while ((callback as IChannel).State == CommunicationState.Opened)
            {
                await callback.SendMessage($"Hello from the server {loop++}");
                await Task.Delay(1000);
            }
        }
    }
}
