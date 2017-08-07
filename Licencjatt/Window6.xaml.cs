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
using System.Windows.Shapes;

namespace Licencjatt
{
    /// <summary>
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        InterpolationN halo = new InterpolationN();
        public Window6()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window1 newton = new Window1();
            newton.ShowDialog();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window3 lagrange = new Window3();
            lagrange.ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Window7 check = new Window7(5);
            check.ShowDialog();
        }
        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            textx0.Content = halo.x[0].ToString();
            textx1.Content = halo.x[1].ToString();
            textx2.Content = halo.x[2].ToString();
            textx3.Content = halo.x[3].ToString();
            textx4.Content = halo.x[4].ToString();
            textf0.Content = halo.f[0].ToString();
            textf1.Content = halo.f[1].ToString();
            textf2.Content = halo.f[2].ToString();
            textf3.Content = halo.f[3].ToString();
            textf4.Content = halo.f[4].ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window6 replay = new Window6();
            replay.ShowDialog();
            
        }
    }
}
