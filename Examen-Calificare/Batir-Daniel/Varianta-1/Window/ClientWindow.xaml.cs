using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Varianta_1.Models;
using Varianta_1.Models.Entities;

namespace Varianta_1.Window
{
    public partial class ClientWindow : MainWindow
    {
        public OnlineShopDbContext _context;
        public ClientWindow()
        {
            InitializeComponent();
        }

        private void saveClient_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client();
            client.Nume = numeTBX.Text;
            client.Prenume = prenumeTBX.Text;
            client.Email = emailTBX.Text;
            client.Telefon = telefonTBX.Text;

            _context.Clienti.Add(client);
        }

        private void cancelClient_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
