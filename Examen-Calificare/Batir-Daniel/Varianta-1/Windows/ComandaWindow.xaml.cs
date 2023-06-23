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
using Varianta_1.ViewModels.Comanda;

namespace Varianta_1.Windows
{

    public partial class ComandaWindow
    {
        public ComandaViewModel model;
        public ComandaWindow()
        {
            InitializeComponent();

            model = new ComandaViewModel();
            DataContext = model;
        }
        private void cancelComanda_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            e.Cancel = true;
        }
    }
}
