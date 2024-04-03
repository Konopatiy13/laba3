using laba3.ViewModel;
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
    /// Логика взаимодействия для Win6.xaml
    /// </summary>
    public partial class Win6 : Window
    {
        public Win6()
        {
            InitializeComponent();
            DataContext = new zd6();
        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as zd6).Metod(tb1.Text, lb3);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
