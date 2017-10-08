﻿using System;
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
       InterpolationN newton = new InterpolationN();
       InterpolationL lagrange = new InterpolationL();
        Numbers number = new Numbers();


        public Window9()
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


            Window7 check = new Window7(4, number);
            check.Owner = this;
            check.ShowDialog();
          
        }



        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            randomizeData();
        }
        private void randomizeData()
        { 
            textx0.Content = lagrange.x[0].ToString();
            textx1.Content = lagrange.x[1].ToString();
            textx2.Content = lagrange.x[2].ToString();
            textx3.Content = lagrange.x[3].ToString();
            textf0.Content = lagrange.f[0].ToString();
            textf1.Content = lagrange.f[1].ToString();
            textf2.Content = lagrange.f[2].ToString();
            textf3.Content = lagrange.f[3].ToString();
            k.Content = lagrange.k[0].ToString();
            lagrange.ObliczL(4);
            label1.Content = lagrange.z.ToString();

            number.Numbers8[0] = textx0.Content.ToString();
            number.Numbers8[1] = textx1.Content.ToString();
            number.Numbers8[2] = textx2.Content.ToString();
            number.Numbers8[3] = textx3.Content.ToString();
            number.Numbers8[4] = textf0.Content.ToString();
            number.Numbers8[5] = textf1.Content.ToString();
            number.Numbers8[6] = textf2.Content.ToString();
            number.Numbers8[7] = textf3.Content.ToString();
            number.Numbers8[8] = label1.Content.ToString();

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window9 replay = new Window9();
            replay.ShowDialog();
        }
    }
    
}

