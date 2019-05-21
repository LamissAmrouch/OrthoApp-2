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
    /// Logique d'interaction pour Window3.xaml
    /// </summary>
    public partial class Window21 : Window
    {
        public Window21()
        {
            InitializeComponent();
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void HomeBtnClick(object sender, RoutedEventArgs e)
        {

            Window1 win1 = new Window1();
            win1.Show();
            this.Close();
        }

        private void  SensClick(object sender, RoutedEventArgs e)
        {
            Window22 win22 = new Window22();
            win22.Show();
            this.Close();
        }

        private void mesactionsClick(object sender, RoutedEventArgs e)
        {
            Window23 win23 = new Window23();
            win23.Show();
            this.Close();
        }

        private void moncorpsClick(object sender, RoutedEventArgs e)
        {
            Window24 win24 = new Window24();
            win24.Show();
            this.Close();
        }
    }
}
