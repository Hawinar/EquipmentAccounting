using EquipmentAccounting.Models;
using System.Linq;
using System.Windows.Controls;

namespace EquipmentAccounting.Pages
{
    /// <summary>
    /// Логика взаимодействия для LocationHistoryPage.xaml
    /// </summary>
    public partial class LocationHistoryPage : Page
    {
        public LocationHistoryPage()
        {
            InitializeComponent();
            DGLocationHistory.ItemsSource = EquipmentDBEntities.GetEntities().LocationHistory.ToList();
        }
    }
}
