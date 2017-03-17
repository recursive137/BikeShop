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
    /// Interaction logic for Contact.xaml
    /// </summary>
    public partial class Contact : Page
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void Grid_SaySomething(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("SaySomething");
        }

        private void Button_SayGoodbye(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("SayGoodbye");
        }

        private void Button_SayHello(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Say Hello");
        }

        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Say Hello");
        }

        private void Button_SayHello(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Say Hello");
        }

        //private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{

        //}

        //private void Button_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        //{

        //}

        //private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{

        //}
    }
}
