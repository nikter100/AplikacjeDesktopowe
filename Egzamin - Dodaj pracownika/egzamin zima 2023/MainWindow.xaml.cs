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

namespace egzamin_zima_2023
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string haslo = "";
        public MainWindow()
        {
            InitializeComponent();

        }

        public void Generuj_Click(object sender, RoutedEventArgs e)
        {
            string[] mLitery = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] liczby = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string[] znakiSpec = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")","_","-","=","+"};
            int iloscZnakow = int.Parse(ilosc.Text);
            Random r = new Random();
            int zmianaZnakow = 0;
            haslo = "";
            

            if (litery.IsChecked == true)
            {
                int znak = r.Next(0, mLitery.Length);
                haslo += mLitery[znak].ToUpper();
                zmianaZnakow++;
            }
            if (cyfry.IsChecked == true)
            {
                int znak = r.Next(0, liczby.Length);
                haslo += liczby[znak];
                zmianaZnakow++;
            }
            if (znaki.IsChecked == true)
            {
                int znak = r.Next(0, znakiSpec.Length);
                haslo += znakiSpec[znak];
                zmianaZnakow++;
            }

            for (int i = 0; i < iloscZnakow - zmianaZnakow; i++)
            {
                int znak = r.Next(0, mLitery.Length);
                haslo += mLitery[znak];
            }

            MessageBox.Show(haslo);
        }

        private void Zatwierdz_Click(object sender, RoutedEventArgs e)
        {



            MessageBox.Show($"Dane pracownika:{imie.Text} {nazwisko.Text} {stanowiska.Text} Hasło: {haslo}");
        }
    }
}
