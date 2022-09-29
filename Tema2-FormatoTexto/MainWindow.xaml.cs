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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextUsuario_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CuadroAmarillo_TextBlock.Text = TextUsuario_TextBox.Text;
        }

        private void Negrita_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = new CheckBox();
            
            if ()
                CuadroAmarillo_TextBlock.FontWeight = FontWeights.Bold;
            else
                CuadroAmarillo_TextBlock.FontWeight = FontWeights.Normal;
            
        }

        private void Cursiva_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if(Cursiva_CheckBox.IsChecked == true)
                CuadroAmarillo_TextBlock.FontStyle = FontStyles.Italic;
            else
                CuadroAmarillo_TextBlock.FontStyle = FontStyles.Normal;
        }

        private void Azul_Radio_Checked(object sender, RoutedEventArgs e)
        {
            CuadroAmarillo_TextBlock.Foreground = Brushes.Blue;
        }

        private void Rojo_Radio_Checked(object sender, RoutedEventArgs e)
        {
            CuadroAmarillo_TextBlock.Foreground = Brushes.Red;
        }

        private void Verde_Radio_Checked(object sender, RoutedEventArgs e)
        {
            CuadroAmarillo_TextBlock.Foreground = Brushes.Green;
        }
    }
}