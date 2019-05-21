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
using System.Xml;

namespace App2
{
    /// <summary>
    /// Logique d'interaction pour Window11.xaml
    /// </summary>
    public partial class Window11 : Window
    {

        private XmlDocument monFichier = new XmlDocument();
        static private int CurrentQuestion;
        private int i = 1;
        // private int i = new Random().Next(20); //debut des questions l'indice de la premiere question
        //private int rep;
        private int totalQuestion;
        private string path;
        //private XmlNode quest;
        // private int cpt = 0;
        // private XmlNode r;
        // private int score = 0;

        int nbQuest = 0;



        public int GetNbQuest()
        { return (nbQuest); }



        /*Affiche des images a partir d'un autre emplacement en donnant son chemin */
        private static BitmapImage GetImage(string imageUri)
        {
            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(imageUri, UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            return bitmapImage;
        }


        /* Récupere la question et ses images associées a partir d'un fichier xml */
        private void GetQuestionFromFile(string path)
        {

            String image1 = monFichier.SelectSingleNode(path + "/Prop1").InnerText;
            ImageChoix2.Source = GetImage(@"Images/couleurs/" + image1);
            name1.Inlines.Clear();
            name1.Inlines.Add(new Run(monFichier.SelectSingleNode(path + "/Prop2").InnerText));
        }


        public Window11()
        {
            InitializeComponent();

            monFichier.Load("couleurs.xml");

            totalQuestion = 10;

            blue.Position = TimeSpan.Zero;
            blue.Play();

            //Sauvgarde de l'indice de la premiere question "utile pour le corigé"
            /* questionChoisi = monFichier.SelectSingleNode("//TestFinal/DebutQuestionsFaites");
             CurrentQuestion = int.Parse(questionChoisi.InnerText);
             //path = "//TestFinal/Probleme" + CurrentQuestion;*/
            CurrentQuestion = i;
            path = "//TestFinal/Probleme" + i;
            //Remplir le StackPanel par les images
            GetQuestionFromFile(path);
        } 




        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void NextClick(object sender, RoutedEventArgs e)
        {
            //S'il est arrivé a la dernière case il remet CurrentQuestion a 1
            if (CurrentQuestion == totalQuestion) { CurrentQuestion = 1; }
            else CurrentQuestion++;

            path = "//TestFinal/Probleme" + CurrentQuestion;
            //Remplir le RichTextBox et le StackPanel par les images
            GetQuestionFromFile(path);
            //Incrémente le numéro de la question courante
            nbQuest++;

            switch (CurrentQuestion)
            {
                case 1:
                    blue.Position = TimeSpan.Zero;
                    blue.Play();
                    break;

                case 2:
                    gris.Position = TimeSpan.Zero;
                    gris.Play();
                    break;

                case 3:
                    jaune.Position = TimeSpan.Zero;
                    jaune.Play();
                    break;

                case 4:
                    marron.Position = TimeSpan.Zero;
                    marron.Play();
                    break;

                case 5:
                    mauve.Position = TimeSpan.Zero;
                    mauve.Play();
                    break;

                case 6:
                    noir.Position = TimeSpan.Zero;
                    noir.Play();
                    break;

                case 7:
                    orange.Position = TimeSpan.Zero;
                    orange.Play();
                    break;

                case 8:
                    rose.Position = TimeSpan.Zero;
                    rose.Play();
                    break;

                case 9:
                    rouge.Position = TimeSpan.Zero;
                    rouge.Play();
                    break;

                case 10:
                    vert.Position = TimeSpan.Zero;
                    vert.Play();
                    break;

            }
            }


        private void PrecedentClick(object sender, RoutedEventArgs e)
        {

            //S'il est arrivé a la dernière case il remet CurrentQuestion a 1
            if (CurrentQuestion == 1) { CurrentQuestion = totalQuestion; }
            else CurrentQuestion--;

            path = "//TestFinal/Probleme" + CurrentQuestion;
            //Remplir le RichTextBox et le StackPanel par les images
            GetQuestionFromFile(path);
            //Incrémente le numéro de la question courante
            nbQuest--;


            switch (CurrentQuestion)
            {
                case 1:
                    blue.Position = TimeSpan.Zero;
                    blue.Play();
                    break;

                case 2:
                    gris.Position = TimeSpan.Zero;
                    gris.Play();
                    break;

                case 3:
                    jaune.Position = TimeSpan.Zero;
                    jaune.Play();
                    break;

                case 4:
                    marron.Position = TimeSpan.Zero;
                    marron.Play();
                    break;

                case 5:
                    mauve.Position = TimeSpan.Zero;
                    mauve.Play();
                    break;

                case 6:
                    noir.Position = TimeSpan.Zero;
                    noir.Play();
                    break;

                case 7:
                    orange.Position = TimeSpan.Zero;
                    orange.Play();
                    break;

                case 8:
                    rose.Position = TimeSpan.Zero;
                    rose.Play();
                    break;

                case 9:
                    rouge.Position = TimeSpan.Zero;
                    rouge.Play();
                    break;

                case 10:
                    vert.Position = TimeSpan.Zero;
                    vert.Play();
                    break;

            }

        }

        private void RetourBtnClick(object sender, RoutedEventArgs e)
        {
            Window5 win5 = new Window5();
            win5.Show();
            this.Close();
        }

        private void sons_MouseDown(object sender, MouseButtonEventArgs e)
        {
            switch (CurrentQuestion)
            {
                case 1:
                    blue.Position = TimeSpan.Zero;
                    blue.Play();
                    break;

                case 2:
                    gris.Position = TimeSpan.Zero;
                    gris.Play();
                    break;

                case 3:
                    jaune.Position = TimeSpan.Zero;
                    jaune.Play();
                    break;

                case 4:
                    marron.Position = TimeSpan.Zero;
                    marron.Play();
                    break;

                case 5:
                    mauve.Position = TimeSpan.Zero;
                    mauve.Play();
                    break;

                case 6:
                    noir.Position = TimeSpan.Zero;
                    noir.Play();
                    break;

                case 7:
                    orange.Position = TimeSpan.Zero;
                    orange.Play();
                    break;

                case 8:
                    rose.Position = TimeSpan.Zero;
                    rose.Play();
                    break;

                case 9:
                    rouge.Position = TimeSpan.Zero;
                    rouge.Play();
                    break;

                case 10:
                    vert.Position = TimeSpan.Zero;
                    vert.Play();
                    break;

            }
        }
    }
}
