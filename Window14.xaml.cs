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
    /// Logique d'interaction pour Window14.xaml
    /// </summary>
    public partial class Window14 : Window
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
            ImageChoix2.Source = GetImage(@"Images/choses/" + image1);
            name1.Inlines.Clear();
            name1.Inlines.Add(new Run(monFichier.SelectSingleNode(path + "/Prop2").InnerText));
        }


        public Window14()
        {
            InitializeComponent();
            monFichier.Load("choses.xml");

            totalQuestion = 23;

            arbre.Position = TimeSpan.Zero;
            arbre.Play();

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

          
            switch(CurrentQuestion)
            {
                case 1 :
                    arbre.Position = TimeSpan.Zero;
                    arbre.Play();
                    break;

                case 2 :
                    flower.Position = TimeSpan.Zero;
                    flower.Play();
                    break;

                case 3 :
                    gason.Position = TimeSpan.Zero;
                    gason.Play();
                    break;

                case 4 :
                    soleil.Position = TimeSpan.Zero;
                    soleil.Play();
                    break;

                case 5 :
                    lune.Position = TimeSpan.Zero;
                    lune.Play();
                    break; 

                case 6 :
                    armoire.Position = TimeSpan.Zero;
                    armoire.Play();
                    break; 

                case  7 :
                    table.Position = TimeSpan.Zero;
                    table.Play();
                    break;

                case 8 :
                    chaise.Position = TimeSpan.Zero;
                    chaise.Play();
                    break;

                case 9:
                    lit.Position = TimeSpan.Zero;
                    lit.Play();
                    break;

                case 10 :
                    tricot.Position = TimeSpan.Zero;
                    tricot.Play();
                    break;

                case 11:
                    shoes.Position = TimeSpan.Zero;
                    shoes.Play();
                    break;

                case 12:
                    chapeau.Position = TimeSpan.Zero;
                    chapeau.Play();
                    break;

                case 13:
                    pontalon.Position = TimeSpan.Zero;
                    pontalon.Play();
                    break;


                case 14:
                    tele.Position = TimeSpan.Zero;
                    tele.Play();
                    break;

                case 15:
                    computer.Position = TimeSpan.Zero;
                    computer.Play();
                    break;


                case 16:
                    phone.Position = TimeSpan.Zero;
                    phone.Play();
                    break;

                case 17:
                    balllon.Position = TimeSpan.Zero;
                    balllon.Play();
                    break;


                case 18:
                    verre.Position = TimeSpan.Zero;
                    verre.Play();
                    break;

                case 19:
                    asseite.Position = TimeSpan.Zero;
                    asseite.Play();
                    break;

                case 20:
                    fourchette.Position = TimeSpan.Zero;
                    fourchette.Play();
                    break;


                case 21:
                    coteau.Position = TimeSpan.Zero;
                    coteau.Play();
                    break;

                case 22:
                    cuilliere.Position = TimeSpan.Zero;
                    cuilliere.Play();
                    break;

                case 23:
                    bouitteil.Position = TimeSpan.Zero;
                    bouitteil.Play();
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
                    arbre.Position = TimeSpan.Zero;
                    arbre.Play();
                    break;

                case 2:
                    flower.Position = TimeSpan.Zero;
                    flower.Play();
                    break;

                case 3:
                    gason.Position = TimeSpan.Zero;
                    gason.Play();
                    break;

                case 4:
                    soleil.Position = TimeSpan.Zero;
                    soleil.Play();
                    break;

                case 5:
                    lune.Position = TimeSpan.Zero;
                    lune.Play();
                    break;

                case 6:
                    armoire.Position = TimeSpan.Zero;
                    armoire.Play();
                    break;

                case 7:
                    table.Position = TimeSpan.Zero;
                    table.Play();
                    break;

                case 8:
                    chaise.Position = TimeSpan.Zero;
                    chaise.Play();
                    break;

                case 9:
                    lit.Position = TimeSpan.Zero;
                    lit.Play();
                    break;

                case 10:
                    tricot.Position = TimeSpan.Zero;
                    tricot.Play();
                    break;

                case 11:
                    shoes.Position = TimeSpan.Zero;
                    shoes.Play();
                    break;

                case 12:
                    chapeau.Position = TimeSpan.Zero;
                    chapeau.Play();
                    break;

                case 13:
                    pontalon.Position = TimeSpan.Zero;
                    pontalon.Play();
                    break;


                case 14:
                    tele.Position = TimeSpan.Zero;
                    tele.Play();
                    break;

                case 15:
                    computer.Position = TimeSpan.Zero;
                    computer.Play();
                    break;


                case 16:
                    phone.Position = TimeSpan.Zero;
                    phone.Play();
                    break;

                case 17:
                    balllon.Position = TimeSpan.Zero;
                    balllon.Play();
                    break;


                case 18:
                    verre.Position = TimeSpan.Zero;
                    verre.Play();
                    break;

                case 19:
                    asseite.Position = TimeSpan.Zero;
                    asseite.Play();
                    break;

                case 20:
                    fourchette.Position = TimeSpan.Zero;
                    fourchette.Play();
                    break;


                case 21:
                    coteau.Position = TimeSpan.Zero;
                    coteau.Play();
                    break;

                case 22:
                    cuilliere.Position = TimeSpan.Zero;
                    cuilliere.Play();
                    break;

                case 23:
                    bouitteil.Position = TimeSpan.Zero;
                    bouitteil.Play();
                    break;


            }




        }

        private void RetourBtnClick(object sender, RoutedEventArgs e)
        {
            Window8 win8 = new Window8();
            win8.Show();
            this.Close();
        }

        private void Sons_MouseDown(object sender, MouseButtonEventArgs e)
        {
            switch (CurrentQuestion)
            {
                case 1:
                    arbre.Position = TimeSpan.Zero;
                    arbre.Play();
                    break;

                case 2:
                    flower.Position = TimeSpan.Zero;
                    flower.Play();
                    break;

                case 3:
                    gason.Position = TimeSpan.Zero;
                    gason.Play();
                    break;

                case 4:
                    soleil.Position = TimeSpan.Zero;
                    soleil.Play();
                    break;

                case 5:
                    lune.Position = TimeSpan.Zero;
                    lune.Play();
                    break;

                case 6:
                    armoire.Position = TimeSpan.Zero;
                    armoire.Play();
                    break;

                case 7:
                    table.Position = TimeSpan.Zero;
                    table.Play();
                    break;

                case 8:
                    chaise.Position = TimeSpan.Zero;
                    chaise.Play();
                    break;

                case 9:
                    lit.Position = TimeSpan.Zero;
                    lit.Play();
                    break;

                case 10:
                    tricot.Position = TimeSpan.Zero;
                    tricot.Play();
                    break;

                case 11:
                    shoes.Position = TimeSpan.Zero;
                    shoes.Play();
                    break;

                case 12:
                    chapeau.Position = TimeSpan.Zero;
                    chapeau.Play();
                    break;

                case 13:
                    pontalon.Position = TimeSpan.Zero;
                    pontalon.Play();
                    break;


                case 14:
                    tele.Position = TimeSpan.Zero;
                    tele.Play();
                    break;

                case 15:
                    computer.Position = TimeSpan.Zero;
                    computer.Play();
                    break;


                case 16:
                    phone.Position = TimeSpan.Zero;
                    phone.Play();
                    break;

                case 17:
                    balllon.Position = TimeSpan.Zero;
                    balllon.Play();
                    break;


                case 18:
                    verre.Position = TimeSpan.Zero;
                    verre.Play();
                    break;

                case 19:
                    asseite.Position = TimeSpan.Zero;
                    asseite.Play();
                    break;

                case 20:
                    fourchette.Position = TimeSpan.Zero;
                    fourchette.Play();
                    break;


                case 21:
                    coteau.Position = TimeSpan.Zero;
                    coteau.Play();
                    break;

                case 22:
                    cuilliere.Position = TimeSpan.Zero;
                    cuilliere.Play();
                    break;

                case 23:
                    bouitteil.Position = TimeSpan.Zero;
                    bouitteil.Play();
                    break;


            }
        }
    }
}
