using EquipmentAccounting.Models;
using System.Linq;
using System.Windows.Controls;

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
