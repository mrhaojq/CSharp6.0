using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WeakEventsNET
{
    class Program
    {
        static void Main(string[] args)
        {

            var dealer = new CarDealer();

            var daniel = new Consumer("Daniel");
            WeakEventManager<CarDealer, CarInfoEventArgs>.AddHandler(dealer, "NewCarInfo", daniel.NewCarIsHere);

            dealer.NewCar("Mercedes");

            var sebastian = new Consumer("Sebastian");
            WeakEventManager<CarDealer, CarInfoEventArgs>.AddHandler(dealer, "NewCarInfo", sebastian.NewCarIsHere);

            dealer.NewCar("Ferrari");

            WeakEventManager<CarDealer, CarInfoEventArgs>.RemoveHandler(dealer, "NewCarInfo", daniel.NewCarIsHere);

            dealer.NewCar("Red Bull Racing");
        }
    }
}
