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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window4 example1 = new Window4();
            example1.ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Window8 example2 = new Window8();
            example2.ShowDialog();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window9 example3 = new Window9();
            example3.ShowDialog();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Window6 example4 = new Window6();
            example4.ShowDialog();
        }
    }
}
