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

namespace BikeShop
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public class Car
        {
            public int Speed { get; set; }
        }
        public Menu()
        {
            InitializeComponent();

            var cars = new List<Car>();
            for (int i = 0; i < 10; i++)
            {
                cars.Add(new Car() { Speed = i * 10 });
            }

            this.DataContext = cars;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Contact.xaml", UriKind.Relative));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Discussion.xaml", UriKind.Relative));
        }
    }
}
