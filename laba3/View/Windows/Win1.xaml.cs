using laba3.ViewModel;
using System.Windows;

namespace laba3.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Win1.xaml
    /// </summary>
    public partial class Win1 : Window
    {
        public Win1()
        {
            InitializeComponent();
            DataContext = new zd1();
        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as zd1).Metod(tb.Text, lb);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();    
        }
    }
}
