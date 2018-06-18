using System;
using static System.Console;

namespace EventsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EventsSample!");
            //创建一个保护事件的实例
            var dealer = new CarDealer();
           
            var daniel = new Consumer("Daniel");
            //注册 事件daniel.NewCarIsHere 
            dealer.NewCarInfo += daniel.NewCarIsHere;
            //触发事件 回调daniel.NewCarIsHere;
            dealer.NewCar("Mercedes");

            var sebastian = new Consumer("Sebastian");
            //注册 sebastian.NewCarIsHere 
            dealer.NewCarInfo += sebastian.NewCarIsHere;
            //触发事件 回调daniel.NewCarIsHere; sebastian.NewCarIsHere;
            dealer.NewCar("Ferrari");

            dealer.NewCarInfo -= sebastian.NewCarIsHere;

            dealer.NewCar("Red Bull Racing");

            ReadKey();
        }
    }
}
