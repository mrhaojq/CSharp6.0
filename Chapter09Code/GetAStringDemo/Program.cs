using System;
using static System.Console;

namespace GetAStringDemo
{
    class Program
    {
        //委托的创建  约定参数类型及返回类型
        public delegate string GetAString();

        static void Main(string[] args)
        {
            Console.WriteLine("GetAStringDemo");
            int x = 40;

            //委托绑定方法
            GetAString firstStringMethod = new GetAString(x.ToString);//不能写成x.ToString() 这个是方法的调用 需要的是传递方法本身
            GetAString secondStringMethod = x.ToString; //可以使用委托推断 给委托绑定方法 两种方式 C#编译器创建的代码是一样的
            //委托调用 这两种方式相同 
            firstStringMethod();
            WriteLine($"firstStringMethod() 方式调用： { firstStringMethod()}");
            firstStringMethod.Invoke();
            WriteLine($"firstStringMethod.Invoke() 方式调用： {  firstStringMethod.Invoke()}");


            var balance = new Currency(34, 50);

            //委托指向实例方法
            firstStringMethod = balance.ToString;
            WriteLine($"balance.ToString is {firstStringMethod()}");

            //委托指向静态方法
            firstStringMethod = Currency.GetCurrencyUnit;
            WriteLine($"Currency.GetCurrencyUnit is {firstStringMethod()}");

            //本节只是给委托绑定方法，使用委托调用方法
            //没有设计把文档当作参数，传递给其他方法
            //也没有体现委托的方便之处
            ReadKey();
        }
    }
}
