﻿using System;
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

namespace ZdarzeniaTrasowane
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

        private void przycisk_Click(object sender, RoutedEventArgs e)
        {
            //(sender as Button).Content = "Zdarzenia trasowane";

            (sender as Button).Background = new SolidColorBrush(Colors.Yellow);

            lista.Items.Add($"C nadawca {(sender as Control).Name}, źródło {(e.Source as Control).Name}, orginalne źródło {(e.OriginalSource as Control).Name}");
        }
    }
}
