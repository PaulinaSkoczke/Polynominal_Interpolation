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
        
        InterpolationL lagrange = new InterpolationL();
        Numbers number = new Numbers();
       

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
           
                
                
                
                Window7 check = new Window7(2, number);
                check.Owner = this;
                check.ShowDialog();
          


        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            randomizeData();
            
        }
        private void randomizeData()
        {
            textx0.Content = lagrange.x[0].ToString();
            textx1.Content = lagrange.x[1].ToString();
            textf0.Content = lagrange.f[0].ToString();
            textf1.Content = lagrange.f[1].ToString();
            k.Content = lagrange.k[0].ToString();
            lagrange.ObliczL(2);
            label1.Content = lagrange.z.ToString();
            
            
            number.Numbers4[0] = textx0.Content.ToString();
            number.Numbers4[1] = textx1.Content.ToString();
            number.Numbers4[2] = textf0.Content.ToString();
            number.Numbers4[3] = textf1.Content.ToString();
            number.Numbers4[4] = label1.Content.ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window4 replay = new Window4();
            replay.ShowDialog();
        }
    }
}
