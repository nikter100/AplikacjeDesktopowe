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

namespace Egzamin_lato_2023
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

        private void Sprawdz_Cene_Click(object sender, RoutedEventArgs e)
        {
            if (pocztowkaCheck.IsChecked == true)
            {
                pocztowka.Visibility = Visibility.Visible;
                paczka.Visibility = Visibility.Collapsed;
                list.Visibility = Visibility.Collapsed;

                cena.Content = "Cena 1 zł";
            }
            else if (listCheck.IsChecked == true)
            {
                pocztowka.Visibility = Visibility.Collapsed;
                paczka.Visibility = Visibility.Collapsed;
                list.Visibility = Visibility.Visible;

                cena.Content = "Cena 1,5 zł";
            }
            else if (paczkaCheck.IsChecked == true)
            {
                pocztowka.Visibility = Visibility.Collapsed;
                paczka.Visibility = Visibility.Visible;
                list.Visibility = Visibility.Collapsed;

                cena.Content = "Cena 10 zł";
            }
        }

        private void Zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            if (kod.Text.Length < 5 || kod.Text.Length > 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
            else if (int.TryParse(kod.Text, out int text))
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone");
            }
            else
            {
                MessageBox.Show("Kod pocztowy powiniene się składać z samych cyfr");
            }
            
        }
    }
}
