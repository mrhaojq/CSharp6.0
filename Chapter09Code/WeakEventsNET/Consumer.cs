using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Console;

namespace WeakEventsNET
{
    public class Consumer : IWeakEventListener
    {
        private string _name;

        public Consumer(string name)
        {
            this._name = name;

        }

        public void NewCarIsHere(object sender, CarInfoEventArgs e)
        {
            WriteLine($"{_name}: car {e.Car} is new");
        }

        public bool ReceiveWeakEvent(Type managerType, object sender, EventArgs e)
        {
            NewCarIsHere(sender, e as CarInfoEventArgs);
            return true;
        }
    }
}
