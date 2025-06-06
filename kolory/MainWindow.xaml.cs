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

namespace kolory
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            sliders_ValueChanged(null, null);
        }

        private void sliders_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            Color kolor = Color.FromRgb(
                (byte)sliderR.Value,
                (byte)sliderG.Value,
                (byte)sliderB.Value);

            rectangle.Fill = new SolidColorBrush(kolor);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape) Close();
        }
    }
}
