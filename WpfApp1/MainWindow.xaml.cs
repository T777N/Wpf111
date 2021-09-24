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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        public int work = 0;
        public MainWindow()
        {
            InitializeComponent();
           
           
            

            
        }

        private void sliderIpon_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            newLbl.Content = (int)sliderIpon.Value;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (work == 0)
            {
                iponBtn.Margin = new Thickness(207, 109, 553, 276);
            }
        }
    }
}
