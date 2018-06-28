using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyHelloServiceHost host = new MyHelloServiceHost())
            {
                host.Open();
                ReadLine();
            }
        }
    }
}
