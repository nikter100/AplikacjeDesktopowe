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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int randomChoice()
        {
            Random rnd = new Random();
            int roll = rnd.Next(3);

            return roll;
        }

        private void AiImage(int rand)
        {
            if (rand == 0)
            {
                AiChoice.Visibility = Visibility.Hidden;
            }
        }

        private void check(int choice)
        {
            String[] choices = { "Paper", "Kamień", "Nożyce" };
            int rand = randomChoice();
            AiImage(rand);

            if (randomChoice() == choice)
            {
                MessageBox.Show("Remis! \n\n Twój wybór: " + choices[choice] + " Wybór AI: " + choices[rand]);
            }
            else if ((rand == 0 && choice == 1) || (rand == 1 && choice == 2) || (rand == 2 && choice == 0))
            {
                MessageBox.Show("Przegrałeś! \n\n Twoj wybór:" + choices[choice] + " Wybór AI: " + choices[rand]);
            }
            else
            {

            }

        }


        private void papper_Click(object sender, RoutedEventArgs e)
        {
            int choice = 0;
            MyChoice.Visibility = Visibility.Hidden;
            MyChoicePapper.Visibility = Visibility.Visible;

            check(choice);
        }

        private void rock_Click(object sender, RoutedEventArgs e)
        {
            int choice = 1;
            MyChoice.Visibility = Visibility.Hidden;
            MyChoiceRock.Visibility = Visibility.Visible;

            check(choice);
        }

        private void scissors_Click(object sender, RoutedEventArgs e)
        {
            int choice = 2;
            MyChoice.Visibility = Visibility.Hidden;
            MyChoiceScissors.Visibility = Visibility.Visible;

            check(choice);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyChoice.Visibility = Visibility.Visible;
            MyChoicePapper.Visibility = Visibility.Hidden;
            MyChoiceRock.Visibility = Visibility.Hidden;
            MyChoiceScissors.Visibility = Visibility.Hidden;
        }
    }
}
