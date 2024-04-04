using laba3.ViewModel;
using System.Collections.Generic;
using System.Windows;

namespace laba3.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Win9.xaml
    /// </summary>
    public partial class Win9 : Window
    {
        public Win9()
        {
            InitializeComponent();
            DataContext = new zd9();
            //DGR.ItemsSource = new List<object>();
            //ComboBox1.ItemsSource = new Person[]
            //{
            //    new Person { name = "Tom", age = 10 },
            //};
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as zd9).Metod(DGR);
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
