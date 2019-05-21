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
    public partial class Window23 : Window
    {
        public Window23()
        {
            InitializeComponent();
            myMedia.Volume = 100;
            myMedia.Position = TimeSpan.Zero;
            myMedia.Play();
        }

        void mediaPlay(Object sender, EventArgs e)
        {
            //myMedia.Position = TimeSpan.Zero;
            myMedia.Play();
        }


        void mediaPause(Object sender, EventArgs e)
        {
            myMedia.Pause();
        }


        void mediaMute(Object sender, EventArgs e)
        {
            if (myMedia.Volume == 100)
            {
                myMedia.Volume = 0;
                muteButt.Content = "Listen";
            }
            else
            {
                myMedia.Volume = 100;
                muteButt.Content = "Mute";
            }
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RetourBtnClick(object sender, RoutedEventArgs e)
        {
            Window21 win21 = new Window21();
            win21.Show();
            this.Close();
        }


    }
}
