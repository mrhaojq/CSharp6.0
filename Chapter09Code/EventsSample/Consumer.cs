using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace EventsSample
{
    /// <summary>
    /// Event Listener
    /// </summary>
  public  class Consumer
    {
        private string _name;

        public Consumer(string name)
        {
            _name = name;
        }

        /// <summary>
        /// 该方法与CarDealer中定义的事件（委托）是匹配的，用户注册到事件中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NewCarIsHere(object sender, CarInfoEventArgs e)
        {
            WriteLine($"{_name}:car {e.Car} is new");
        }
    }
}
