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
    /// Logique d'interaction pour Window12.xaml
    /// </summary>
    public partial class Window12 : Window
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
            ImageChoix2.Source = GetImage(@"Images/legumes/" + image1);
            name1.Inlines.Clear();
            name1.Inlines.Add(new Run(monFichier.SelectSingleNode(path + "/Prop2").InnerText));
        }


        public Window12()
        {
            InitializeComponent();
            monFichier.Load("legumess.xml");

            totalQuestion = 8 ;
            tomate.Position = TimeSpan.Zero;
            tomate.Play();

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
                    tomate.Position = TimeSpan.Zero;
                    tomate.Play();
                    break;

                case 2:
                    salade.Position = TimeSpan.Zero;
                    salade.Play();
                    break;

                case 3:
                    cucumber.Position = TimeSpan.Zero;
                   cucumber.Play();
                    break;

                case 4:
                    gralic.Position = TimeSpan.Zero;
                    gralic.Play();
                    break;

                case 5:
                    onion.Position = TimeSpan.Zero;
                    onion.Play();
                    break;

                case 6:
                    potato.Position = TimeSpan.Zero;
                    potato.Play();
                    break;

                case 7:
                    carrot.Position = TimeSpan.Zero;
                    carrot.Play();
                    break;

                case 8:
                    poivre.Position = TimeSpan.Zero;
                    poivre.Play();
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
                    tomate.Position = TimeSpan.Zero;
                    tomate.Play();
                    break;

                case 2:
                    salade.Position = TimeSpan.Zero;
                    salade.Play();
                    break;

                case 3:
                    cucumber.Position = TimeSpan.Zero;
                    cucumber.Play();
                    break;

                case 4:
                    gralic.Position = TimeSpan.Zero;
                    gralic.Play();
                    break;

                case 5:
                    onion.Position = TimeSpan.Zero;
                    onion.Play();
                    break;

                case 6:
                    potato.Position = TimeSpan.Zero;
                    potato.Play();
                    break;

                case 7:
                    carrot.Position = TimeSpan.Zero;
                    carrot.Play();
                    break;

                case 8:
                    poivre.Position = TimeSpan.Zero;
                    poivre.Play();
                    break;

            }

        }

        private void RetourBtnClick(object sender, RoutedEventArgs e)
        {
            Window6 win6 = new Window6();
            win6.Show();
            this.Close();
        }

        private void sons_MouseDown(object sender, MouseButtonEventArgs e)
        {

            switch (CurrentQuestion)
            {
                case 1:
                    tomate.Position = TimeSpan.Zero;
                    tomate.Play();
                    break;

                case 2:
                    salade.Position = TimeSpan.Zero;
                    salade.Play();
                    break;

                case 3:
                    cucumber.Position = TimeSpan.Zero;
                    cucumber.Play();
                    break;

                case 4:
                    gralic.Position = TimeSpan.Zero;
                    gralic.Play();
                    break;

                case 5:
                    onion.Position = TimeSpan.Zero;
                    onion.Play();
                    break;

                case 6:
                    potato.Position = TimeSpan.Zero;
                    potato.Play();
                    break;

                case 7:
                    carrot.Position = TimeSpan.Zero;
                    carrot.Play();
                    break;

                case 8:
                    poivre.Position = TimeSpan.Zero;
                    poivre.Play();
                    break;

            }
        }
    }
}
