using EquipmentAccounting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

namespace EquipmentAccounting.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Equipment currentEquipment = new Equipment();
        private static Frame mainnnnFrame;

        object tmpLocation;
        object tmpStatus;
        public AddEditPage(Frame mainFrame, Equipment selectedEquipment)
        {
            InitializeComponent();
            mainnnnFrame = mainFrame;
            if (selectedEquipment != null)
            {
                currentEquipment = selectedEquipment;
                DataContext = currentEquipment;
                tbType.Text = selectedEquipment.Type;
                tbNumber.Text = selectedEquipment.Number;

                tmpLocation = selectedEquipment.Location;
                tbLocation.Text = selectedEquipment.Location;

                tmpStatus = selectedEquipment.Status;
                tbStatus.Text = selectedEquipment.Status;

            }
        }
        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            if (currentEquipment.Id == 0)
                Add();
            else
                Change();
            mainnnnFrame.Navigate(new Pages.MainPage(mainnnnFrame));
        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            mainnnnFrame.Navigate(new Pages.MainPage(mainnnnFrame));
        }
        public void Add()
        {
            currentEquipment.Type = tbType.Text;
            currentEquipment.Number = tbNumber.Text;
            currentEquipment.Location = tbLocation.Text;
            currentEquipment.Status = tbStatus.Text;

            try
            {
                EquipmentDBEntities.GetEntities().Equipment.Add(currentEquipment);
                EquipmentDBEntities.GetEntities().SaveChanges();

                DateTime dateTime = DateTime.Now;

                LocationHistory locationHistory = new LocationHistory();
                locationHistory.EquipmentId = currentEquipment.Id;
                locationHistory.Location = currentEquipment.Location;
                locationHistory.ChangeDate = dateTime;
                EquipmentDBEntities.GetEntities().LocationHistory.Add(locationHistory);

                StatusHistory statusHistory = new StatusHistory();
                statusHistory.EquipmentId = currentEquipment.Id;
                statusHistory.Status = currentEquipment.Status;
                statusHistory.ChangeDate = dateTime;
                EquipmentDBEntities.GetEntities().StatusHistory.Add(statusHistory);

                EquipmentDBEntities.GetEntities().SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void Change()
        {
            currentEquipment.Type = tbType.Text;
            currentEquipment.Number = tbNumber.Text;
            currentEquipment.Location = tbLocation.Text;
            currentEquipment.Status = tbStatus.Text;

            DateTime dateTime = DateTime.Now;

            try
            {
                if (tmpLocation.ToString() != tbLocation.Text)
                {
                    LocationHistory locationHistory = new LocationHistory();
                    locationHistory.EquipmentId = currentEquipment.Id;
                    locationHistory.Location = currentEquipment.Location;
                    locationHistory.ChangeDate = dateTime;
                    EquipmentDBEntities.GetEntities().LocationHistory.Add(locationHistory);
                }
                if (tmpStatus.ToString() != tbStatus.Text)
                {
                    StatusHistory statusHistory = new StatusHistory();
                    statusHistory.EquipmentId = currentEquipment.Id;
                    statusHistory.Status = currentEquipment.Status;
                    statusHistory.ChangeDate = dateTime;
                    EquipmentDBEntities.GetEntities().StatusHistory.Add(statusHistory);
                }
                EquipmentDBEntities.GetEntities().SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
