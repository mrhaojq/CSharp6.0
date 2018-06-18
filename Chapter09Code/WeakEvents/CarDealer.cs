using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace WeakEvents
{
    /// <summary>
    /// 自定义事件参数
    /// </summary>
    public class CarInfoEventArgs : EventArgs
    {
        public string Car { get; }

        public CarInfoEventArgs(string car)
        {
            this.Car = car;
        }
    }

    /// <summary>
    /// Event Publisher
    /// </summary>
  public  class CarDealer
    {

        public event EventHandler<CarInfoEventArgs> NewCarInfo;

        public void NewCar(string car)
        {
            NewCarInfo?.Invoke(this, new CarInfoEventArgs(car));
        }
    }
}
