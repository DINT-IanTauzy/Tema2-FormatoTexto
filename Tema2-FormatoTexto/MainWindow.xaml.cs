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
            Azul_Radio.IsChecked = true;
        }

        private void TextUsuario_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CuadroAmarillo_TextBlock.Text = TextUsuario_TextBox.Text;
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


        private void CheckedNegrita(object sender, RoutedEventArgs e)
        {
            CuadroAmarillo_TextBlock.FontWeight = FontWeights.Bold;
        }

        private void UnCheckedNegrita(object sender, RoutedEventArgs e)
        {
            CuadroAmarillo_TextBlock.FontWeight = FontWeights.Normal;
        }

        private void CheckedCursiva(object sender, RoutedEventArgs e)
        {
            CuadroAmarillo_TextBlock.FontStyle = FontStyles.Italic;
        }

        private void UnCheckedCursiva(object sender, RoutedEventArgs e)
        {
            CuadroAmarillo_TextBlock.FontStyle = FontStyles.Normal;
        }
    }
}
