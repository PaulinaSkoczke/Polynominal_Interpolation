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
        
        public Window7(int[] f)
        {
            InitializeComponent();

            Values2 = new ChartValues<int> { halo.f[0], halo.f[1], halo.f[2], halo.f[3]};

            DataContext = this;
        }

        public ChartValues<int> Values2 { get; set; }

        //Values1 = new ChartValues<double> { };


        //DataContext = this;
    

        //public ChartValues<double> Values1 { get; set; }
    

    }

}
