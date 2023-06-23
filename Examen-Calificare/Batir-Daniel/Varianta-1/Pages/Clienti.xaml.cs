using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Varianta_1.Models.Entities;
using Varianta_1.ViewModels.Client;
using Varianta_1.Windows;

namespace Varianta_1.Pages
{
    public partial class Clienti : Page
    {
        private ClientWindow clientWindow;
        public ClientViewModel model;
        public OnlineShopDbContext _context;
        public ObservableCollection<Client> clients;
        public Clienti()
        {
            InitializeComponent();

            clientWindow = new ClientWindow();
            model = new ClientViewModel();
            _context = new OnlineShopDbContext();
            DataContext = model;

            clients = new ObservableCollection<Client>(_context.GetClients());
            clientsDataGrid.ItemsSource = clients;
        }

        private void addClient_Click(object sender, RoutedEventArgs e)
        {
            clientWindow.Show();
        }

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            clients.Clear();

            foreach (var client in _context.GetClients())
            {
                clients.Add(client);
            }
        }
    }
}
