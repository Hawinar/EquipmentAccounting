using EquipmentAccounting.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EquipmentAccounting.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {

        private static Frame MainFrame;

        public MainPage(Frame mainFrame)
        {
            InitializeComponent();
            DGEquipment.ItemsSource = EquipmentDBEntities.GetEntities().Equipment.ToList();
            MainFrame = mainFrame;
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.AddEditPage(MainFrame, (sender as Button).DataContext as Equipment));
        }
        private void Delete(object sender, RoutedEventArgs e)
        {
            Equipment d = (sender as Button).DataContext as Equipment;

            int targetId = d.Id;


            EquipmentDBEntities.GetEntities().Equipment.Remove(d);
            EquipmentDBEntities.GetEntities().LocationHistory.RemoveRange(EquipmentDBEntities.GetEntities().LocationHistory.Where(x => x.EquipmentId == targetId).ToList());
            EquipmentDBEntities.GetEntities().StatusHistory.RemoveRange(EquipmentDBEntities.GetEntities().StatusHistory.Where(x => x.EquipmentId == targetId).ToList());
            EquipmentDBEntities.GetEntities().SaveChanges();
            DGEquipment.ItemsSource = EquipmentDBEntities.GetEntities().Equipment.ToList();
        }
        private void Edit(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.AddEditPage(MainFrame, (sender as Button).DataContext as Equipment));
        }
        private void Focus(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.FocusPage((sender as Button).DataContext as Equipment));
        }
        private void Search(object sender, RoutedEventArgs e)
        {
            switch (cbSizeBy.SelectedIndex)
            {
                case 0:
                    DGEquipment.ItemsSource = EquipmentDBEntities.GetEntities().Equipment.Where(x => x.Type == tbTarget.Text).ToList();
                    break;
                case 1:
                    DGEquipment.ItemsSource = EquipmentDBEntities.GetEntities().Equipment.Where(x => x.Number == tbTarget.Text).ToList();
                    break;
                case 2:
                    DGEquipment.ItemsSource = EquipmentDBEntities.GetEntities().Equipment.Where(x => x.Location == tbTarget.Text).ToList();
                    break;
                case 3:
                    DGEquipment.ItemsSource = EquipmentDBEntities.GetEntities().Equipment.Where(x => x.Status == tbTarget.Text).ToList();
                    break;
            }
        }
        private void Reset(object sender, RoutedEventArgs e)
        {
            DGEquipment.ItemsSource = EquipmentDBEntities.GetEntities().Equipment.ToList();
            tbTarget.Text = string.Empty;
        }

    }
}
