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
