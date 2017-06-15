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
        InterpolationNL halo = new InterpolationNL();
        
        public Window7(int n)
        {
            InitializeComponent();
            int zmienna1;
            int zmienna2;
            int zmienna3;
            int zmienna4;

            if (n == 2)
            {
               
                zmienna1 = halo.f[0];
                zmienna2 = halo.f[1];

                Values2 = new ChartValues<int> { zmienna1, zmienna2 };
            }
            else if (n == 3)
            {
                zmienna1 = halo.f[0];
                zmienna2 = halo.f[1];
                zmienna3 = halo.f[2];

                Values2 = new ChartValues<int> { zmienna1, zmienna2, zmienna3 };

            }
            else if (n == 4)
            {
                zmienna1 = halo.f[0];
                zmienna2 = halo.f[1];
                zmienna3 = halo.f[2];
                zmienna4 = halo.f[3];

                Values2 = new ChartValues<int> { zmienna1, zmienna2, zmienna3 };

            }
            DataContext = this;
        }

        public ChartValues<int> Values2 { get; set; }

        //Values1 = new ChartValues<double> { };


        //DataContext = this;
    

        //public ChartValues<double> Values1 { get; set; }
    

    }

}
