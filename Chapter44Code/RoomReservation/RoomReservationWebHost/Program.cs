using System;
using static System.Console;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RoomReservationWebHost
{
    class Program
    {
        static void Main()
        {
            try
            {
                var baseAddress = new Uri("http://localhost:9000/RoomReservation");
                var host = new WebServiceHost(typeof(RoomReservationService.RoomReservationService), baseAddress);
                host.Open();

                WriteLine("service running");
                WriteLine("Press return to exit...");
                ReadLine();

                if (host.State == CommunicationState.Opened)
                    host.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
