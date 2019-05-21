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
    /// Logique d'interaction pour Window15.xaml
    /// </summary>
    public partial class Window20 : Window
    {

        private XmlDocument monFichier = new XmlDocument();
        static private int CurrentQuestion;
        private int i = 1;
        // private int i = new Random().Next(20); //debut des questions l'indice de la premiere question
        //private int rep;
        private int totalQuestion;
        private string path;
        private int rep;
        //private XmlNode quest;
        // private int cpt = 0;
        // private XmlNode r;
        // private int score = 0;
        private int score = 0;
        private XmlNode r;


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
            ImageChoix1.Source = GetImage(@"Images/choses/" + image1);

            String image2 = monFichier.SelectSingleNode(path + "/Prop2").InnerText;
            ImageChoix2.Source = GetImage(@"Images/choses/" + image2);

            String image3 = monFichier.SelectSingleNode(path + "/Prop3").InnerText;
            ImageChoix3.Source = GetImage(@"Images/choses/" + image3);
            // name1.Inlines.Clear();
            // name1.Inlines.Add(new Run(monFichier.SelectSingleNode(path + "/Prop2").InnerText));
        }


        public Window20()
        {
            InitializeComponent();

            monFichier.Load("exo_choses.xml");

            totalQuestion = 10;

            coteau.Position = TimeSpan.Zero;
            coteau.Play();


            //Sauvgarde de l'indice de la premiere question "utile pour le corigé"
            /* questionChoisi = monFichier.SelectSingleNode("//TestFinal/DebutQuestionsFaites");
             CurrentQuestion = int.Parse(questionChoisi.InnerText);
             //path = "//TestFinal/Probleme" + CurrentQuestion;*/
            CurrentQuestion = i;
            path = "//TestFinal/Probleme" + i;
            //Remplir le StackPanel par les images
            GetQuestionFromFile(path);
            t1.Visibility = Visibility.Hidden;
            t2.Visibility = Visibility.Hidden;
            t3.Visibility = Visibility.Hidden;

            f1.Visibility = Visibility.Hidden;
            f2.Visibility = Visibility.Hidden;
            f3.Visibility = Visibility.Hidden;
            affiche.Visibility = Visibility.Hidden;
            textBlock.Visibility = Visibility.Hidden;
            image.Visibility = Visibility.Hidden;

            QuestSuiv.IsEnabled = false;
            ValiderQuest.IsEnabled = false;


        }


        private void ImageChoix1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            rep = 1;

            ValiderQuest.IsEnabled = true;

        }


        private void ImageChoix2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            rep = 2;
            ValiderQuest.IsEnabled = true;
        }


        private void ImageChoix3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            rep = 3;
            ValiderQuest.IsEnabled = true;
        }


        private void QuestSuiv_Click(object sender, RoutedEventArgs e)
        {

            sons.IsEnabled = true;
            QuestSuiv.IsEnabled = false;
            t1.Visibility = Visibility.Hidden;
            t2.Visibility = Visibility.Hidden;
            t3.Visibility = Visibility.Hidden;
            f1.Visibility = Visibility.Hidden;
            f2.Visibility = Visibility.Hidden;
            f3.Visibility = Visibility.Hidden;

            if (CurrentQuestion < totalQuestion)
            {
                CurrentQuestion++;
                path = "//TestFinal/Probleme" + CurrentQuestion;
                //Remplir le RichTextBox et le StackPanel par les images
                GetQuestionFromFile(path);

              switch (CurrentQuestion)
                {
                    case 1:
                        coteau.Position = TimeSpan.Zero;
                        coteau.Play();
                        break;

                    case 2:
                        flower.Position = TimeSpan.Zero;
                        flower.Play();
                        break;

                    case 3:
                        verre.Position = TimeSpan.Zero;
                        verre.Play();
                        break;

                    case 4:
                        soleil.Position = TimeSpan.Zero;
                        soleil.Play();
                        break;

                    case 5:
                        tele.Position = TimeSpan.Zero;
                        tele.Play();
                        break;

                    case 6:
                        pontalon.Position = TimeSpan.Zero;
                        pontalon.Play();
                        break;

                    case 7:
                        table.Position = TimeSpan.Zero;
                        table.Play();
                        break;

                    case 8:
                        chapeau.Position = TimeSpan.Zero;
                        chapeau.Play();
                        break;

                    case 9:
                        lit.Position = TimeSpan.Zero;
                        lit.Play();
                        break;

                    case 10:
                        balllon.Position = TimeSpan.Zero;
                        balllon.Play();
                        break;
                }
               

            }

            else // la fin de exo : afficahge du resultats 
            {
                cont1.Visibility = Visibility.Hidden;
                cont2.Visibility = Visibility.Hidden;
                cont3.Visibility = Visibility.Hidden;
                ImageChoix1.Visibility = Visibility.Hidden;
                ImageChoix2.Visibility = Visibility.Hidden;
                ImageChoix3.Visibility = Visibility.Hidden;
                QuestSuiv.Visibility = Visibility.Hidden;
                ValiderQuest.Visibility = Visibility.Hidden;
                r1.Visibility = Visibility.Hidden;
                r2.Visibility = Visibility.Hidden;
                r3.Visibility = Visibility.Hidden;
                r4.Visibility = Visibility.Hidden;
                r5.Visibility = Visibility.Hidden;
                r6.Visibility = Visibility.Hidden;
                r7.Visibility = Visibility.Hidden;
                r8.Visibility = Visibility.Hidden;
                r9.Visibility = Visibility.Hidden;
                r10.Visibility = Visibility.Hidden;
                sons.Visibility = Visibility.Hidden;


                if (score == 0)
                {
                    affiche.Visibility = Visibility.Visible;
                    textBlock.Visibility = Visibility.Visible;
                    image.Visibility = Visibility.Visible;
                    textBlock.Text = " لقد تحصلت على العلامة " + " " + score + "/10" + " أعد المحاولة ";
                    image.Source = GetImage(@"Images/brainstorm.png");

                }

                if ((score <= 5) && (score > 0))
                {
                    affiche.Visibility = Visibility.Visible;
                    textBlock.Visibility = Visibility.Visible;
                    image.Visibility = Visibility.Visible;
                    textBlock.Text = "  أحسنت لقد تحصلت على العلامة " + " " + score + "/10";
                    image.Source = GetImage(@"Images/gift.png");
                }

                if ((score <= 10) && (score > 5))
                {
                    affiche.Visibility = Visibility.Visible;
                    textBlock.Visibility = Visibility.Visible;
                    image.Visibility = Visibility.Visible;
                    textBlock.Text = "  أحسنت لقد تحصلت على العلامة " + " " + score + "/10";
                    image.Source = GetImage(@"Images/cup.png");
                }

            }


        }


        private void ValiderQuest_Click(object sender, RoutedEventArgs e)
        {

            sons.IsEnabled = false;
            QuestSuiv.IsEnabled = true;
            ValiderQuest.IsEnabled = false;
            path = "//TestFinal/Probleme" + CurrentQuestion;
            r = monFichier.SelectSingleNode(path + "/R");
            int res = int.Parse(r.InnerText);


            //  Next.IsEnabled = true;

            if (res == rep)
            {

                // le sons indiquant que la reponse est correcte 
                Correct.Position = TimeSpan.Zero;
                Correct.Play();
                // incrementer le score 
                score++;
                // remplissage du rectangle 

                switch (score)
                {
                    case 1:
                        r1.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF5C994A"));
                        break;

                    case 2:
                        r2.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF5C994A"));
                        break;

                    case 3:
                        r3.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF5C994A"));
                        break;

                    case 4:
                        r4.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF5C994A"));
                        break;

                    case 5:
                        r5.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF5C994A"));
                        break;

                    case 6:
                        r6.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF5C994A"));
                        break;

                    case 7:
                        r7.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF5C994A"));
                        break;

                    case 8:
                        r8.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF5C994A"));
                        break;

                    case 9:
                        r9.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF5C994A"));
                        break;

                    case 10:
                        r10.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF5C994A"));
                        break;
                }

            }
            else
            {
                Wrong.Position = TimeSpan.Zero;
                Wrong.Play();

            }



            if (res == 1)
            {
                t1.Visibility = Visibility.Visible;
                t2.Visibility = Visibility.Hidden;
                t3.Visibility = Visibility.Hidden;
                f2.Visibility = Visibility.Visible;
                f1.Visibility = Visibility.Hidden;
                f3.Visibility = Visibility.Visible;
            }


            if (res == 2)
            {
                t2.Visibility = Visibility.Visible;
                t1.Visibility = Visibility.Hidden;
                t3.Visibility = Visibility.Hidden;

                f1.Visibility = Visibility.Visible;
                f2.Visibility = Visibility.Hidden;
                f3.Visibility = Visibility.Visible;

            }


            if (res == 3)
            {
                t3.Visibility = Visibility.Visible;
                t2.Visibility = Visibility.Hidden;
                t1.Visibility = Visibility.Hidden;

                f2.Visibility = Visibility.Visible;
                f3.Visibility = Visibility.Hidden;
                f1.Visibility = Visibility.Visible;

            }

        }




        private void Sons_MouseDown(object sender, MouseButtonEventArgs e)
        {

            switch (CurrentQuestion)
            {
                case 1:
                    coteau.Position = TimeSpan.Zero;
                    coteau.Play();
                    break;

                case 2:
                    flower.Position = TimeSpan.Zero;
                    flower.Play();
                    break;

                case 3:
                    verre.Position = TimeSpan.Zero;
                    verre.Play();
                    break;

                case 4:
                    soleil.Position = TimeSpan.Zero;
                    soleil.Play();
                    break;

                case 5:
                    tele.Position = TimeSpan.Zero;
                    tele.Play();
                    break;

                case 6:
                    pontalon.Position = TimeSpan.Zero;
                    pontalon.Play();
                    break;

                case 7:
                    table.Position = TimeSpan.Zero;
                    table.Play();
                    break;

                case 8:
                    chapeau.Position = TimeSpan.Zero;
                    chapeau.Play();
                    break;

                case 9:
                    lit.Position = TimeSpan.Zero;
                    lit.Play();
                    break;

                case 10:
                    balllon.Position = TimeSpan.Zero;
                    balllon.Play();
                    break;
            }


        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void RetourBtnClick(object sender, RoutedEventArgs e)
        {
            Window8 win8 = new Window8();
            win8.Show();
            this.Close();
        }




    }
}
