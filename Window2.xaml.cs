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
    /// Logique d'interaction pour Window2.xaml
    /// </summary>
    public partial class Window2 : Window
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
             ImageChoix1.Source = GetImage(@"Images/animaux/" + image1);
             name.Inlines.Clear();
             name.Inlines.Add(new Run(monFichier.SelectSingleNode(path + "/Prop2").InnerText));
        }



        public Window2()
        {
               InitializeComponent();
               monFichier.Load("animaux.xml");
               totalQuestion = 25 ;

            cat.Position = TimeSpan.Zero;
            cat.Play();

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
                case 1 :
                    cat.Position = TimeSpan.Zero;
                    cat.Play();
                    break;

                case 2:
                    oiseau.Position = TimeSpan.Zero;
                    oiseau.Play();
                    break;

                case 3:
                    chicken.Position = TimeSpan.Zero;
                    chicken.Play();
                    break;

                case 4:
                    dog.Position = TimeSpan.Zero;
                    dog.Play();
                    break;

                case 5:
                    fish.Position = TimeSpan.Zero;
                    fish.Play();
                    break;

                case 6:
                    horse.Position = TimeSpan.Zero;
                    horse.Play();
                    break;

                case 7:
                    rabbit.Position = TimeSpan.Zero;
                    rabbit.Play();
                    break;

                case 8:
                    sheep.Position = TimeSpan.Zero;
                    sheep.Play();
                    break;

                case 9:
                    camel.Position = TimeSpan.Zero;
                    camel.Play();
                    break;

                case 10:
                    snail.Position = TimeSpan.Zero;
                    snail.Play();
                    break;

                case 11:
                    lion.Position = TimeSpan.Zero;
                    lion.Play();
                    break;

                case 12:
                    cow.Position = TimeSpan.Zero;
                    cow.Play();
                    break;

                case 13:
                    cat.Position = TimeSpan.Zero;
                    cat.Play();
                    break;


                case 14:
                    fish.Position = TimeSpan.Zero;
                    fish.Play();
                    break;

                case 15:
                    chicken.Position = TimeSpan.Zero;
                    chicken.Play();
                    break;


                case 16:
                    lion.Position = TimeSpan.Zero;
                    lion.Play();
                    break;

                case 17:
                    sheep.Position = TimeSpan.Zero;
                    sheep.Play();
                    break;


                case 18:
                    dog.Position = TimeSpan.Zero;
                    dog.Play();
                    break;

                case 19:
                    rabbit.Position = TimeSpan.Zero;
                    rabbit.Play();
                    break;

                case 20:
                    cow.Position = TimeSpan.Zero;
                    cow.Play();
                    break;

                case 21:
                    horse.Position = TimeSpan.Zero;
                    horse.Play();
                    break;

                case 22:
                   papillon.Position = TimeSpan.Zero;
                   papillon.Play();
                    break;

                case 23:
                    bee.Position = TimeSpan.Zero;
                    bee.Play();
                    break; 

                case 24:
                    snail.Position = TimeSpan.Zero;
                    snail.Play();
                    break;

                case 25:
                    fourmi.Position = TimeSpan.Zero;
                    fourmi.Play();
                    break;
               
            }

      }
              
              
             
        private void PrecedentClick(object sender, RoutedEventArgs e)
        {

            //S'il est arrivé a la dernière case il remet CurrentQuestion a 1
            if (CurrentQuestion == 1) { CurrentQuestion = totalQuestion ; }
            else CurrentQuestion--;

            path = "//TestFinal/Probleme" + CurrentQuestion;
            //Remplir le RichTextBox et le StackPanel par les images
            GetQuestionFromFile(path);
            //Incrémente le numéro de la question courante
            nbQuest-- ;

            switch (CurrentQuestion)
            {
                case 1:
                    cat.Position = TimeSpan.Zero;
                    cat.Play();
                    break;

                case 2:
                    oiseau.Position = TimeSpan.Zero;
                    oiseau.Play();
                    break;

                case 3:
                    chicken.Position = TimeSpan.Zero;
                    chicken.Play();
                    break;

                case 4:
                    dog.Position = TimeSpan.Zero;
                    dog.Play();
                    break;

                case 5:
                    fish.Position = TimeSpan.Zero;
                    fish.Play();
                    break;

                case 6:
                    horse.Position = TimeSpan.Zero;
                    horse.Play();
                    break;

                case 7:
                    rabbit.Position = TimeSpan.Zero;
                    rabbit.Play();
                    break;

                case 8:
                    sheep.Position = TimeSpan.Zero;
                    sheep.Play();
                    break;

                case 9:
                    camel.Position = TimeSpan.Zero;
                    camel.Play();
                    break;

                case 10:
                    snail.Position = TimeSpan.Zero;
                    snail.Play();
                    break;

                case 11:
                    lion.Position = TimeSpan.Zero;
                    lion.Play();
                    break;

                case 12:
                    cow.Position = TimeSpan.Zero;
                    cow.Play();
                    break;

                case 13:
                    cat.Position = TimeSpan.Zero;
                    cat.Play();
                    break;


                case 14:
                    fish.Position = TimeSpan.Zero;
                    fish.Play();
                    break;

                case 15:
                    chicken.Position = TimeSpan.Zero;
                    chicken.Play();
                    break;


                case 16:
                    lion.Position = TimeSpan.Zero;
                    lion.Play();
                    break;

                case 17:
                    sheep.Position = TimeSpan.Zero;
                    sheep.Play();
                    break;


                case 18:
                    dog.Position = TimeSpan.Zero;
                    dog.Play();
                    break;

                case 19:
                    rabbit.Position = TimeSpan.Zero;
                    rabbit.Play();
                    break;

                case 20:
                    cow.Position = TimeSpan.Zero;
                    cow.Play();
                    break;

                case 21:
                    horse.Position = TimeSpan.Zero;
                    horse.Play();
                    break;

                case 22:
                    papillon.Position = TimeSpan.Zero;
                    papillon.Play();
                    break;

                case 23:
                    bee.Position = TimeSpan.Zero;
                    bee.Play();
                    break;

                case 24:
                    snail.Position = TimeSpan.Zero;
                    snail.Play();
                    break;

                case 25:
                    fourmi.Position = TimeSpan.Zero;
                    fourmi.Play();
                    break;

            }

        }

        private void RetourBtnClick(object sender, RoutedEventArgs e)
        {
            Window3 win3 = new Window3();
            win3.Show();
            this.Close();
        }

        private void sons_MouseDown(object sender, MouseButtonEventArgs e)
        {
            switch (CurrentQuestion)
            {
                case 1:
                    cat.Position = TimeSpan.Zero;
                    cat.Play();
                    break;

                case 2:
                    oiseau.Position = TimeSpan.Zero;
                    oiseau.Play();
                    break;

                case 3:
                    chicken.Position = TimeSpan.Zero;
                    chicken.Play();
                    break;

                case 4:
                    dog.Position = TimeSpan.Zero;
                    dog.Play();
                    break;

                case 5:
                    fish.Position = TimeSpan.Zero;
                    fish.Play();
                    break;

                case 6:
                    horse.Position = TimeSpan.Zero;
                    horse.Play();
                    break;

                case 7:
                    rabbit.Position = TimeSpan.Zero;
                    rabbit.Play();
                    break;

                case 8:
                    sheep.Position = TimeSpan.Zero;
                    sheep.Play();
                    break;

                case 9:
                    camel.Position = TimeSpan.Zero;
                    camel.Play();
                    break;

                case 10:
                    snail.Position = TimeSpan.Zero;
                    snail.Play();
                    break;

                case 11:
                    lion.Position = TimeSpan.Zero;
                    lion.Play();
                    break;

                case 12:
                    cow.Position = TimeSpan.Zero;
                    cow.Play();
                    break;

                case 13:
                    cat.Position = TimeSpan.Zero;
                    cat.Play();
                    break;


                case 14:
                    fish.Position = TimeSpan.Zero;
                    fish.Play();
                    break;

                case 15:
                    chicken.Position = TimeSpan.Zero;
                    chicken.Play();
                    break;


                case 16:
                    lion.Position = TimeSpan.Zero;
                    lion.Play();
                    break;

                case 17:
                    sheep.Position = TimeSpan.Zero;
                    sheep.Play();
                    break;


                case 18:
                    dog.Position = TimeSpan.Zero;
                    dog.Play();
                    break;

                case 19:
                    rabbit.Position = TimeSpan.Zero;
                    rabbit.Play();
                    break;

                case 20:
                    cow.Position = TimeSpan.Zero;
                    cow.Play();
                    break;

                case 21:
                    horse.Position = TimeSpan.Zero;
                    horse.Play();
                    break;

                case 22:
                    papillon.Position = TimeSpan.Zero;
                    papillon.Play();
                    break;

                case 23:
                    bee.Position = TimeSpan.Zero;
                    bee.Play();
                    break;

                case 24:
                    snail.Position = TimeSpan.Zero;
                    snail.Play();
                    break;

                case 25:
                    fourmi.Position = TimeSpan.Zero;
                    fourmi.Play();
                    break;

            }
        }
    }
}
