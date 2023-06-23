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
using Varianta_1.Models;
using Varianta_1.ViewModels.Comanda;
using Varianta_1.Windows;

namespace Varianta_1.Pages
{
    /// <summary>
    /// Interaction logic for Comenzi.xaml
    /// </summary>
    public partial class Comenzi : Page
    {
        private ComandaWindow comandaWindow;
        private OnlineShopDbContext _context;
        private ComandaViewModel model;
        public Comenzi()
        {
            InitializeComponent();
            comandaWindow = new ComandaWindow();
            _context = new OnlineShopDbContext();
            model = new ComandaViewModel();

            comenziDataGrid.ItemsSource = _context.GetOrders();
            DataContext = model;
        }

        private void addOrder_Click(object sender, RoutedEventArgs e)
        {
            comandaWindow.ShowDialog();
        }

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            comenziDataGrid.ItemsSource = _context.GetOrders();
        }
    }
}
