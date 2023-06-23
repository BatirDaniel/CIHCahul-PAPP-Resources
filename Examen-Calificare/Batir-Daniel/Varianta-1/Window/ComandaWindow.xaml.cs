using Microsoft.EntityFrameworkCore;
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
using System.Windows.Shapes;
using Varianta_1.Models;
using Varianta_1.Models.Entities;

namespace Varianta_1.Window
{

    public partial class ComandaWindow : MainWindow
    {
        public OnlineShopDbContext _context;
        public ComandaWindow()
        {
            InitializeComponent();
        }

        private void saveComanda_Click(object sender, RoutedEventArgs e)
        {
            Comanda cm = new Comanda();

            cm.SumaTotala = double.Parse(sumaTBX.Text);
            cm.DataComanda = DateTime.Parse(dataComenziTBX.Text);
            cm.CodClient = clientName.Text;

            _context.Comenzi.Add(cm);
        }

        private void cancelComanda_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
