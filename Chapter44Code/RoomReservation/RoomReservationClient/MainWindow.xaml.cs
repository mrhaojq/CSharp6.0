using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ServiceModel;
using RoomReservationContracts;

namespace RoomReservationClient
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private RoomReservation _reservation;

        public MainWindow()
        {
            InitializeComponent();
            _reservation = new RoomReservation { StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(1) };
            this.DataContext = _reservation;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ServiceRef.RoomServiceClient client = new ServiceRef.RoomServiceClient();


                var result = client.ReserveRoomAsync(_reservation).Result;

                client.Close();

                if (result)
                {
                    MessageBox.Show("reservation ok");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
