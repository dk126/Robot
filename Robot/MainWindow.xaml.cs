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

namespace Robot
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
        public int wysokosc;
        public int szerokosc;
        private void zastosujButton_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                wysokosc = Convert.ToInt32(wysokoscTextBox.Text);
                szerokosc = Convert.ToInt32(szerokoscTextBox.Text);
                plaszczyzna.Height = wysokosc;
                plaszczyzna.Width = szerokosc;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public class Position
        {

        }
       

        private void WypiszPozycjeButton_Click(object sender, RoutedEventArgs e)
        {
            pozycjaTextBox.Text = Convert.ToString(Robot.Margin);
        }

        private void wLewoButton_Click(object sender, RoutedEventArgs e)
        {
            RotateTransform rotateTransform1 = new RotateTransform(90);
            rotateTransform1.CenterX = 0;
            rotateTransform1.CenterY = 0;
            Robot.RenderTransform = rotateTransform1;
        }
    }
}
