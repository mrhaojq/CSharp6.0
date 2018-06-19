using System;
using static System.Console;

namespace AnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Anonymous Methods");

            string mid = ", middle part.";

            Func<string, string> anonDel = delegate (string param)
               {
                   param += mid;
                   param += " and this was added to the string.";
                   return param;
               };

            WriteLine(anonDel.Invoke("Start of string"));


            //lambda 方式实现匿名方法 C#3.0引入
            Func<string, string> lambda = param =>
               {
                   param += mid;
                   param += " and this was added to the string.";
                   return param;
               };

            WriteLine(lambda("Start of string"));

            ReadKey();
        }
    }
}
