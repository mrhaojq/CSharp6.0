using System;
using System.Net;
using System.Threading.Tasks;
using static System.Console;

namespace DnsLookup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            do
            {
                Write("Hostname:\t");
                string hostname = ReadLine();
                if (hostname.CompareTo("exit")==0)
                {
                    WriteLine("bye!");
                    return;
                }
                OnLookupAsync(hostname).Wait();
                WriteLine();
            } while (true);

        }

        public static async Task OnLookupAsync(string hostname)
        {
            try
            {
                IPHostEntry ipHost = await Dns.GetHostEntryAsync(hostname);

                WriteLine($"Hostname:{ipHost.HostName}");

                foreach (IPAddress address in ipHost.AddressList)
                {
                    WriteLine($"Address Family:{address.AddressFamily}");
                    WriteLine($"Address:{address}");
                    WriteLine();
                }
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.Message}");
            }
        }
    }
}
