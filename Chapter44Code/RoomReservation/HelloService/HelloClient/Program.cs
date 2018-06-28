using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (HelloProxy proxy = new HelloProxy())
            {
                WriteLine(proxy.Say("mrhao"));
                ReadLine();
            }
        }
    }
}
