﻿using laba3.ViewModel;
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

namespace laba3.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //DataContext = new zd1();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            Win1 win1 = new Win1();
            win1.Show();
            Close();
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            Win2 win2 = new Win2();
            win2.Show();
            Close();
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            Win3 win3 = new Win3();
            win3.Show();
            Close();
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            Win4 win4 = new Win4();
            win4.Show();
            Close();
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            Win5 win5 = new Win5();
            win5.Show();
            Close();
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            Win6 win6 = new Win6();
            win6.Show();
            Close();
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            Win7 win7 = new Win7();
            win7.Show();
            Close();
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            Win8 win8 = new Win8();
            win8.Show();
            Close();
        }


        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            Win9 win9 = new Win9();
            win9.Show();
            Close();
        }

        //private void cb1_Loaded(object sender, RoutedEventArgs e)
        //{
        //    bt1_Click(sender, e);
        //    bt2_Click(sender, e);
        //    bt3_Click(sender, e);
        //    bt4_Click(sender, e);
        //    bt5_Click(sender, e);
        //    bt6_Click(sender, e);
        //    bt7_Click(sender, e);
        //    bt8_Click(sender, e);
        //    bt9_Click(sender, e);
        //}
    }
}
