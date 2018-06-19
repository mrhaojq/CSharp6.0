using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using static System.Console;
using RoomReservationService;

namespace RoomReservationHost
{
    class Program
    {
        internal static ServiceHost s_ServiceHost = null;

        internal static void StartService()
        {
            try
            {
                //通过ServiceHost 将RoomReservationService 中的方法公布出去

                s_ServiceHost = new ServiceHost(typeof(RoomReservationService.RoomReservationService),
                new Uri("http://localhost:9000/RoomReservation"));
                s_ServiceHost.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });
                s_ServiceHost.Open();
            }
            catch (AddressAccessDeniedException)
            {
                WriteLine("either start Visual Studio in elevated admin " +
          "mode or register the listener port with netsh.exe");
            }
        }

        internal static void StopService()
        {
            if (s_ServiceHost != null &&
                     s_ServiceHost.State == CommunicationState.Opened)
            {
                s_ServiceHost.Close();
            }
        }


        static void Main(string[] args)
        {
            StartService();

            WriteLine("Server is running. Press return to exit");
            ReadLine();

            StopService();

            ReadKey();
        }
    }
}
