﻿using System;
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
    /// Logique d'interaction pour Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
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
            Window11 win11 = new Window11();
            win11.Show();
            this.Close();

        }

        private void exerserClick(object sender, RoutedEventArgs e)
        {
            Window17 win17 = new Window17();
            win17.Show();
            this.Close();
        }
    }
}
