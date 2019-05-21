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
    /// Logique d'interaction pour Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
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

        private void decouvrirClick(object sender, RoutedEventArgs e)
        {
            Window12 win12 = new Window12();
            win12.Show();
            this.Close();
        }

        private void ExerserClick(object sender, RoutedEventArgs e)
        {
            Window18 win18 = new Window18();
            win18.Show();
            this.Close();
        }
    }
}
