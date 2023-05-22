using System.Windows;
using System.Windows.Controls;

namespace EquipmentAccounting
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Frame mainFrame;
        public MainWindow()
        {
            InitializeComponent();
            mainFrame = MainFrame;
            MainFrame.Navigate(new Pages.MainPage(mainFrame));
        }
        private void toMainPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.MainPage(mainFrame));
        }
        private void toLocationHistory(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.LocationHistoryPage());
        }

        private void toStatusHistory(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.StatusHistoryPage());
        }
    }
}
