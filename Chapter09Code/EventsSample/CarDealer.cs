using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace EventsSample
{
    /// <summary>
    /// Event Publiser
    /// </summary>
    public class CarDealer
    {
        //public event EventHandler<CarInfoEventArgs> NewCarInfo;
        //The delegate EventHandler<TEventArgs> is defined as follows:
        //public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e)
        //where TEventArgs : EventArgs

          //定义一个特定类型参数的事件（ 委托 没有返回值，接受两个参数，第一个是this,第二个是指定类型的参数）
        public event EventHandler<CarInfoEventArgs> NewCarInfo;

        /// <summary>
        /// 调用注册的所有委托
        /// </summary>
        /// <param name="car"></param>
        public void NewCar(string car)
        {
            WriteLine($"CarDealer,new car {car}");
            //回调注册的方法，触发事件
            NewCarInfo?.Invoke(this, new CarInfoEventArgs(car));//等效于下边的写法

            //if (NewCarInfo!=null)
            //{
            //    NewCarInfo.Invoke(this, new CarInfoEventArgs(car));
            //}
        }
    }
}
