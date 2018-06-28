using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.ServiceReference1;
using System.ServiceModel;
using static System.Console;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("client... wait for the server");
            StartSendRequest();
            WriteLine("next return to exit");
            ReadLine();
            WriteLine("bye...");
        }

        static async void StartSendRequest()
        {
            var callbackInstance = new InstanceContext(new CallbackHandler());
            var client = new DemoServiceClient(callbackInstance);
            await client.StartSendingMessagesAsync();
        }

        private class CallbackHandler : IDemoServiceCallback
        {
            public void SendMessage(string message)
            {
                WriteLine($"messgage from the server {message}");
            }
        }
    }
}
