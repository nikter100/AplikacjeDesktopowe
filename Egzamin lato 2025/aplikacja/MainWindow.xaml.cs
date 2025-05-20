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

namespace aplikacja
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;

        string[] linie = File.ReadAllLines("Data.txt");

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button_Click_Pobrania(object sender, RoutedEventArgs e)
        {
            string ilePobran = iloscPobran.Content.ToString();

            int pobrania = int.Parse(ilePobran);
            pobrania++;

            iloscPobran.Content = pobrania;
        }

        private void Button_Click_Poprzedni(object sender, RoutedEventArgs e)
        {

            i -= 6;

            if (i < 0)
            {
                i = linie.Length - 5;
            }

            if (i < linie.Length)
            {
                artysta.Content = linie[i];
                album.Content = linie[i + 1];
                iloscPiosenek.Content = linie[i + 2] + " utworów";
                rokWydania.Content = linie[i + 3];
                iloscPobran.Content = linie[i + 4];
            }

        }

        private void Button_Click_Nastepny(object sender, RoutedEventArgs e)
        {

            i += 6;

            if (i >= linie.Length)
            {
                i = 0;
            }

            if (i < linie.Length)
            {
                
                artysta.Content = linie[i];
                album.Content = linie[i + 1];
                iloscPiosenek.Content = linie[i + 2] + " utworów";
                rokWydania.Content = linie[i + 3];
                iloscPobran.Content = linie[i + 4];
            }
           
        }
    }
}
