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
    /// Логика взаимодействия для Win7.xaml
    /// </summary>
    public partial class Win7 : Window
    {
        public Win7()
        {
            InitializeComponent();
            DataContext = new zd7();
        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as zd7).Metod(tb1.Text, tb2.Text, lb4);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
