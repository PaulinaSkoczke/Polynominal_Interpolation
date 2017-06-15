using LiveCharts;
using LiveCharts.Wpf;
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
    // <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {



        public Window5()
        {
            InitializeComponent();

            
            }

        public class interpolacjaNewLag
        {
         public int x { get; set; }
         public int f { get; set; }

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            interpolacjaNewLag zmienna = new interpolacjaNewLag();

            textBox.Text = zmienna.x.ToString();
            textBox1.Text = zmienna.f.ToString();

            dataGrid.Items.Add(zmienna);
        }
    }

   
}

