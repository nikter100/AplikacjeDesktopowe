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
using System.IO;

namespace Rozwiazanie
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string numer = numerOsoby.Text;

            string folder = AppDomain.CurrentDomain.BaseDirectory;

            string sciezkaZdjecie = System.IO.Path.Combine(folder, $"{numer}-zdjecie.jpg");
            string sciezkaOdcisk = System.IO.Path.Combine(folder, $"{numer}-odcisk.jpg");

            // Zdjęcie osoby
            if (File.Exists(sciezkaZdjecie))
            {
                zdjOsoby.Source = new BitmapImage(new Uri(sciezkaZdjecie));
                zdjOdcisk.Source = new BitmapImage(new Uri(sciezkaOdcisk));
            }
            else
                zdjOsoby.Source = null; zdjOdcisk.Source = null;
                

            string kolorOczu = "";

            if (kolorOczu1.IsChecked == true)
            {
                kolorOczu = "niebieskie";
            }
            else if (kolorOczu2.IsChecked == true)
            {
                kolorOczu = "zielone";
            }
            else if (kolorOczu3.IsChecked == true)
            {
                kolorOczu = "piwne";
            }

            if (imie.Text == "" || nazwisko.Text == "")
            {
                MessageBox.Show("Wprowadz dane");
            }
            else
                MessageBox.Show($"{imie.Text} {nazwisko.Text} kolor oczu {kolorOczu}");
            






        }
    }
}
