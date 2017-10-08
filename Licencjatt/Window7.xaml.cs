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
        Numbers _nn;
        
        public Window7(int n, Numbers nn)
        {

            _nn = nn;
            InitializeComponent();
          

            if (n == 2)
            {
                
                int f00;
                int f01;
                int x00;
                int x01;
             
                f00 = int.Parse(nn.Numbers4[0]);
                f01 = int.Parse(nn.Numbers4[1]);
                x00 = int.Parse(nn.Numbers4[2]);
                x01 = int.Parse(nn.Numbers4[3]);
                
                Values1 = new ChartValues<int> { f00, f01 };

                Values1 = new ChartValues<int> { x00, x01 };

        

            }
            else if (n == 3)
            {
                
                int f00;
                int f01;
                int f02;
                int x00;
                int x01;
                int x02;
               
                x00 = int.Parse(nn.Numbers6[0]);
                x01 = int.Parse(nn.Numbers6[1]);
                x02 = int.Parse(nn.Numbers6[2]);
                f00 = int.Parse(nn.Numbers6[3]);
                f01 = int.Parse(nn.Numbers6[4]);
                f02 = int.Parse(nn.Numbers6[5]);
                
                Values1 = new ChartValues<int> { f00, f01, f02 };

                Values1 = new ChartValues<int> { x00, x01, x02 };

            }
            else if (n == 4)
            {
                
                int f00;
                int f01;
                int f02;
                int f03;
                int x00;
                int x01;
                int x02;
                int x03;
                x00 = int.Parse(nn.Numbers8[0]);
                x01 = int.Parse(nn.Numbers8[1]);
                x02 = int.Parse(nn.Numbers8[2]);
                x03 = int.Parse(nn.Numbers8[3]);
                f00 = int.Parse(nn.Numbers8[4]);
                f01 = int.Parse(nn.Numbers8[5]);
                f02 = int.Parse(nn.Numbers8[6]);
                f03 = int.Parse(nn.Numbers8[7]);
               

                Values1 = new ChartValues<int> { f00, f01, f02, f03 };

                Values1 = new ChartValues<int> { x00, x01, x02, x03 };
               
            }

            else if (n == 5)
            {
                

                int f00;
                int f01;
                int f02;
                int f03;
                int f04;
                int x00;
                int x01;
                int x02;
                int x03;
                int x04;

                x00 = int.Parse(nn.Numbers10[0]);
                x01 = int.Parse(nn.Numbers10[1]);
                x02 = int.Parse(nn.Numbers10[2]);
                x03 = int.Parse(nn.Numbers10[3]);
                x04 = int.Parse(nn.Numbers10[4]);
                f00 = int.Parse(nn.Numbers10[5]);
                f01 = int.Parse(nn.Numbers10[6]);
                f02 = int.Parse(nn.Numbers10[7]);
                f03 = int.Parse(nn.Numbers10[8]);
                f04 = int.Parse(nn.Numbers10[9]);

                Values1 = new ChartValues<int> { f00, f01, f02, f03, f04 };
                Values1 = new ChartValues<int> { x00, x01, x02, x03, x04 };
            }

            DataContext = this;    
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            label80.Content = _nn.Numbers4[4];
            label80.Content = _nn.Numbers6[6];
            label80.Content = _nn.Numbers8[8];
            label80.Content = _nn.Numbers10[10];


        }

        public ChartValues<int> Values1 { get; set; }
       

       


    }

}
