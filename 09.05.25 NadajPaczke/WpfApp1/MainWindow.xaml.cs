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

        private void sprawdzCeneClick(object sender, RoutedEventArgs e)
        {
            if (pocztowka.IsChecked == true)
            {
                zdjeciePocztowka.Visibility = Visibility.Visible;
                zdjecieList.Visibility = Visibility.Collapsed;
                zdjeciePaczka.Visibility = Visibility.Collapsed;

                cena.Content = "Cena: 1 zł";
            }
            else if (list.IsChecked == true)
            {
                zdjeciePocztowka.Visibility = Visibility.Collapsed;
                zdjecieList.Visibility = Visibility.Visible;
                zdjeciePaczka.Visibility = Visibility.Collapsed;

                cena.Content = "Cena: 1,5 zł";
            }
            else if (paczka.IsChecked == true)
            {
                zdjeciePocztowka.Visibility = Visibility.Collapsed;
                zdjecieList.Visibility = Visibility.Collapsed;
                zdjeciePaczka.Visibility = Visibility.Visible;

                cena.Content = "Cena: 10 zł";
            }
        }

        private void zatwierdClick(object sender, RoutedEventArgs e)
        {
            if (kodPocztowy.Text.Length > 5 || kodPocztowy.Text.Length < 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
            else if (int.TryParse(kodPocztowy.Text, out int kod))
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone");
            }
            else
            {
                MessageBox.Show("Kod podcztowy powinien się składać z samych cyfr");
            }

        }
    }
}
