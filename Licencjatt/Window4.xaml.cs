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
        
        InterpolationN halo = new InterpolationN();

        string a;
        string b;
        

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
            //double porownanie;
            //double porownanie1;


            //halo.ObliczN(2);
            //a = textBox.Text;
            //b = textBox1.Text;

            //porownanie = double.Parse(a);
            //porownanie1 = double.Parse(b);


            //halo.w1 = Math.Round(halo.w1, 2);
            //halo.w2 = Math.Round(halo.w2, 2);


            //if (porownanie == halo.w1 && porownanie1 == halo.w2)
            //{
                
                
                
                Window7 super = new Window7(2);
                super.ShowDialog();
            //}
            //else
            //{
            //    Window10 blad = new Window10();
            //    blad.ShowDialog();
            //}


        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            textx0.Content = halo.x[0].ToString();
            textx1.Content = halo.x[1].ToString();
            textf0.Content = halo.f[0].ToString();
            textf1.Content = halo.f[1].ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window4 replay = new Window4();
            replay.ShowDialog();
        }
    }
}
