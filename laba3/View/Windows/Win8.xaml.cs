using laba3.ViewModel;
using System.Windows;

namespace laba3.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Win8.xaml
    /// </summary>
    public partial class Win8 : Window
    {
        public Win8()
        {
            InitializeComponent();
            DataContext = new zd8();
        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as zd8).Metod1(lv1);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
