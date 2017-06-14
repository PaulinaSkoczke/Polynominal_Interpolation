using LiveCharts;
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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        Interpolation cos = new Interpolation();
        InterpolationNL halo = new InterpolationNL();

        double a;
        double b;
        

        public Window4()
        {
            InitializeComponent();

            

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window1 newton1 = new Window1();
            newton1.ShowDialog();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window3 lagrange1 = new Window3();
            lagrange1.ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            
            
            a = double.Parse(textBox.Text);
            b = double.Parse(textBox1.Text);

            halo.Inte(2);
            halo.w1 = Math.Round(halo.w1, 2);
            halo.w2 = Math.Round(halo.w2, 2);


            if (a == halo.w1 && b == halo.w2)
            {
                
                int[] f;
                
                Window7 super = new Window7(halo.f);
                super.ShowDialog();
            }
            else
            {
                Window6 bee = new Window6();
                bee.ShowDialog();
            }


        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            textx0.Content = halo.x[0].ToString();
            textx1.Content = halo.x[1].ToString();
            textf0.Content = halo.f[0].ToString();
            textf1.Content = halo.f[1].ToString();
        }
    }
}
