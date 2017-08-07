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
    /// Interaction logic for Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        double a;
        double b;
        double c;
        double d;

        InterpolationN halo = new InterpolationN();
        


        public Window9()
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


            //a = double.Parse(textBox.Text);
            //b = double.Parse(textBox1.Text);
            //c = double.Parse(textBox2.Text);
            //d = double.Parse(textBox3.Text);
            //halo.w1 = Math.Round(halo.w1, 2);
            //halo.w2 = Math.Round(halo.w2, 2);
            //halo.w3 = Math.Round(halo.w3, 2);
            //halo.w4 = Math.Round(halo.w4, 2);

            //halo.ObliczN(4);

            //if (a == halo.w1 && b == halo.w2 && c == halo.w3 && d == halo.w4)
            //{
                Window7 brawo = new Window7(4);
                brawo.ShowDialog();
            //}
            //else
            //{
            //    Window10 blad = new Window10();
            //    blad.ShowDialog();
            //}
        }

 

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            textx0.Content = halo.x[0].ToString();
            textx1.Content = halo.x[1].ToString();
            textx2.Content = halo.x[2].ToString();
            textx3.Content = halo.x[3].ToString();
            textf0.Content = halo.f[0].ToString();
            textf1.Content = halo.f[1].ToString();
            textf2.Content = halo.f[2].ToString();
            textf3.Content = halo.f[3].ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window9 replay = new Window9();
            replay.ShowDialog();
        }
    }
    
}

