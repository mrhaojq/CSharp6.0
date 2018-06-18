using System;
using System.Collections.Generic;
using System.Text;

namespace EventsSample
{
    //自定义事件参数
 public  class CarInfoEventArgs:EventArgs
    {
        public string Car { get; }

        public CarInfoEventArgs(string car)
        {
            Car = car;
        }
    }
}
