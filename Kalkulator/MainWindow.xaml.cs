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

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _pierwszaL = 0;
        private int _drugaL = 0;
        private string _operacja = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            while (wyswietlacz.Text == "0")
            {
                wyswietlacz.Text = "";
            }

            if (button != null)
            {
                wyswietlacz.Text += button.Content.ToString();
            }


        }

        private void operation_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (button != null)
            {
                _pierwszaL = int.Parse(wyswietlacz.Text);
                wyswietlacz.Text = "";
                _operacja = button.Content.ToString();
            }
        }

        private void policz(object sender, RoutedEventArgs e)
        {
            double wynik = 0;
            _drugaL = int.Parse(wyswietlacz.Text);
            

            switch (_operacja)
            {
                case "+":
                    wynik = _pierwszaL + _drugaL;
                    break;
                case "-":
                    wynik = _pierwszaL - _drugaL;
                    break;
                case "*":
                    wynik = _pierwszaL * _drugaL;
                    break;
                case "/":
                    if (_drugaL != 0)
                    {
                        wynik = _pierwszaL / _drugaL;
                    }
                    else
                    {
                        wynik = 0;
                        MessageBox.Show("Nie dziel przez zero", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    break;
            }

            wyswietlacz.Text = wynik.ToString();
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text = "0";
            _pierwszaL = 0;
        }
    }
}
