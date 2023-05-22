using EquipmentAccounting.Models;
using System.Linq;
using System.Windows.Controls;

namespace EquipmentAccounting.Pages
{
    /// <summary>
    /// Логика взаимодействия для StatusHistoryPage.xaml
    /// </summary>
    public partial class StatusHistoryPage : Page
    {
        public StatusHistoryPage()
        {
            InitializeComponent();
            DGStatusHistory.ItemsSource = EquipmentDBEntities.GetEntities().StatusHistory.ToList();
        }
    }
}
