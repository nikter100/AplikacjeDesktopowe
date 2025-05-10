using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
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
        private bool sprawdzDane()
        {
            if ((string.IsNullOrWhiteSpace(imie.Text)) || string.IsNullOrWhiteSpace(nazwisko.Text) || string.IsNullOrWhiteSpace(adres.Text) || stanowisko.SelectedIndex == 0)
            {
                MessageBox.Show("Wszystkie dane powinny zostac wypelnione", "Karta Biblioteczna", MessageBoxButton.OK, MessageBoxImage.Information);
                noweImie.Text = "-";
                noweNazwisko.Text = "-";
                nowyAdres.Text = "-";
                noweStanowisko.Text = "-";

                czytelnik.Text = "Czytelnik nie zostal jeszcze zapisany";

                return false;
            }
            return true;
        }
        private void uruchomZapiszDane(object sender, RoutedEventArgs e)
        {
            if (sprawdzDane())
            {
                noweImie.Text = imie.Text;
                noweNazwisko.Text = nazwisko.Text;
                nowyAdres.Text = adres.Text;
                if (stanowisko.SelectedIndex == 1)
                {
                    noweStanowisko.Text = "Nauczyciel";
                }
                else if (stanowisko.SelectedIndex == 2)
                {
                    noweStanowisko.Text = "Pracownik szkoly";
                }
                else if (stanowisko.SelectedIndex == 3)
                {
                    noweStanowisko.Text = "Uczen";
                }

                czytelnik.Text = "Czytelnik zostal zapisany";

                MessageBox.Show("Dane zostaly zapisane", "Karta Biblioteczna", MessageBoxButton.OK, MessageBoxImage.Information);

                imie.Text = string.Empty;
                nazwisko.Text = string.Empty;
                adres.Text = string.Empty;
                stanowisko.SelectedIndex = 0;
            }
        }
    }
}
