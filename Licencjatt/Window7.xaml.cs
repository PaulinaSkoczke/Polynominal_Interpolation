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
using LiveCharts;
using LiveCharts.Wpf;

namespace Licencjatt
{
    /// <summary>
    /// Interaction logic for Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        InterpolationN halo = new InterpolationN();

        public Window7(int n)
        {
            InitializeComponent();
            int f1;
            int f2;
            int f3;
            int f4;
            int f5;
            int x1;
            int x2;
            int x3;
            int x4;
            int x5;


            if (n == 2)
            {

                f1 = halo.f[0];
                f2 = halo.f[1];
                x1 = halo.x[0];
                x2 = halo.x[1];


                Values1 = new ChartValues<int> { f1, f2 };

                Values1 = new ChartValues<int> { x1, x2 };

        

            }
            else if (n == 3)
            {
                f1 = halo.f[0];
                f2 = halo.f[1];
                f3 = halo.f[2];
                x1 = halo.x[0];
                x2 = halo.x[1];
                x3 = halo.x[2];

                Values1 = new ChartValues<int> { f1, f2, f3 };
               
                    Values1 = new ChartValues<int> { x1, x2, x3 };
              
            }
            else if (n == 4)
            {
                f1 = halo.f[0];
                f2 = halo.f[1];
                f3 = halo.f[2];
                f4 = halo.f[3];
                x1 = halo.x[0];
                x2 = halo.x[1];
                x3 = halo.x[2];
                x4 = halo.x[3];

                Values1 = new ChartValues<int> { f1, f2, f3, f4 };

                Values1 = new ChartValues<int> { x1, x2, x3, x4 };
               
            }

            else if (n == 5)
            {
                f1 = halo.f[0];
                f2 = halo.f[1];
                f3 = halo.f[2];
                f4 = halo.f[3];
                f5 = halo.f[4];
                x1 = halo.x[0];
                x2 = halo.x[1];
                x3 = halo.x[2];
                x4 = halo.x[3];
                x5 = halo.x[4];

                Values1 = new ChartValues<int> { f1, f2, f3, f4, f5 };
                //Values1 = new ChartValues<int> { x1, x2, x3, x4, x5 };
            }

            DataContext = this;    
        }
        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            halo.ObliczN(2);
            label1.Content = halo.w1.ToString();
        }

        public ChartValues<int> Values1 { get; set; }
        //public ChartValues<int> Values3 { get; set; }

        //Values1 = new ChartValues<double> { };


        //DataContext = this;


        //public ChartValues<double> Values1 { get; set; }


    }

}
