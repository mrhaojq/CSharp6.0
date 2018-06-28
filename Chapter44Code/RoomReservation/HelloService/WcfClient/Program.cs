using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceRef.Service1Client _client = new ServiceRef.Service1Client();
            Console.WriteLine(_client.GetData(11));
            Console.ReadLine();
        }
    }
}
