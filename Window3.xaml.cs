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
    public partial class Window3 : Window
    {
        public Window3()
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
            Window2 win2 = new Window2();
            win2.Show();
            this.Close();
        }

        private void exercirClick(object sender, RoutedEventArgs e)
        {
            Window15 win15 = new Window15();
            win15.Show();
            this.Close();
                
        }
    } 
}
