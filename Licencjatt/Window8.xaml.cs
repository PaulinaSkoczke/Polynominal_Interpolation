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
    /// Interaction logic for Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        double a;
        double b;
        double c;

        InterpolationNL halo = new InterpolationNL();

        public Window8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

            a = double.Parse(textBox.Text);
            b = double.Parse(textBox1.Text);
            c = double.Parse(textBox2.Text);

            halo.w1 = Math.Round(halo.w1, 2);
            halo.w2 = Math.Round(halo.w2, 2);
            halo.w3 = Math.Round(halo.w3, 2);

            if (halo.w1 == a && halo.w2 == b && halo.w3 == c)
            {
                Window7 brawo = new Window7(f[3]);
                brawo.ShowDialog();
            }
            else
            {
                Window6 bee = new Window6();
                bee.ShowDialog();
            }

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

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            textx0.Content = halo.x[0].ToString();
            textx1.Content = halo.x[1].ToString();
            textx2.Content = halo.x[2].ToString();
            textf0.Content = halo.f[0].ToString();
            textf1.Content = halo.f[1].ToString();
            textf2.Content = halo.f[2].ToString();
        }
    }
}
