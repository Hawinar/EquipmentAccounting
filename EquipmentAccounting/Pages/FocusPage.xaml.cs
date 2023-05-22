using EquipmentAccounting.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EquipmentAccounting.Pages
{
    /// <summary>
    /// Логика взаимодействия для FocusPage.xaml
    /// </summary>
    public partial class FocusPage : Page
    {
        public FocusPage(Equipment selectedEquipment)
        {
            InitializeComponent();
            DGLocationHistory.ItemsSource = EquipmentDBEntities.GetEntities().LocationHistory.Where(x => x.Equipment.Id == selectedEquipment.Id).ToList();
            DGStatusHistory.ItemsSource = EquipmentDBEntities.GetEntities().StatusHistory.Where(x => x.Equipment.Id == selectedEquipment.Id).ToList();
            tbText.Text = $"{selectedEquipment.Type}  {selectedEquipment.Number}  {selectedEquipment.Location}  {selectedEquipment.Status}";

        }
    }
}
