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
    /// Logique d'interaction pour Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
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
            Window13 win13 = new Window13();
            win13.Show();
            this.Close();

        }

        private void exerciserClick(object sender, RoutedEventArgs e)
        {
            Window19 win19 = new Window19();
            win19.Show();
            this.Close();

        } 



    }
}
