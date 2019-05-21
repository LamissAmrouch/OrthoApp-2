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
using System.Windows.Shapes;

namespace App2
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
         

        private void btnclick(object sender, RoutedEventArgs e)
        {
            Window2
                      win2 = new Window2 ();
            win2.Show();  

            this.Close();
        }
         

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonClick(object sender, RoutedEventArgs e)
        {

            Window10 win2 = new Window10 ();
            win2.Show();

            this.Close();

        }

        private void mesanimauxClick(object sender, RoutedEventArgs e)
        {
            Window3 win3 = new Window3();
            win3.Show();
            this.Close();
        }

        private void mesformesClick(object sender, RoutedEventArgs e)
        {
            Window4 win4 = new Window4();
            win4.Show();
            this.Close();
        }

        private void mescoleursClick(object sender, RoutedEventArgs e)
        {
            Window5 win5 = new Window5();
            win5.Show();
            this.Close();
        }

        private void mesfruitsClick(object sender, RoutedEventArgs e)
        {
            Window7 win7 = new Window7();
            win7.Show();
            this.Close();
        }

        private void meslegumesClick(object sender, RoutedEventArgs e)
        {
            Window6 win6 = new Window6();
            win6.Show();
            this.Close();
        }

        private void meschosesClick(object sender, RoutedEventArgs e)
        {
            Window8 win8 = new Window8();
            win8.Show();
            this.Close();
        }

     

        private void photosClick(object sender, RoutedEventArgs e)
        {
            Window9 win9 = new Window9();
            win9.Show();
            this.Close();
        }
         

        private void videosClick(object sender, RoutedEventArgs e)
        {
            Window21 win21 = new Window21();
            win21.Show();
            this.Close();
        }
    }
}
