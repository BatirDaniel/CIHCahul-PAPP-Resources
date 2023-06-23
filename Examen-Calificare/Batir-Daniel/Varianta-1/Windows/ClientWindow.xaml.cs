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
using Varianta_1.ViewModels.Client;

namespace Varianta_1.Windows
{
    public partial class ClientWindow
    {
        public ClientViewModel model;
        public ClientWindow()
        {
            InitializeComponent();

            model = new ClientViewModel();
            DataContext = model;
        }

        private void cancelClient_Click(object sender, RoutedEventArgs e)
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
