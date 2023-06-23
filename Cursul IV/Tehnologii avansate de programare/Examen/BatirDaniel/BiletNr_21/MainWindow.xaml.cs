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

namespace BiletNr_21
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnCalculeaza_Click(object sender, RoutedEventArgs e)
        {
            double MC = 0, MNDP = 0, MNEA = 0, ntLDI = 0, ntLS = 0, ntM = 0;

            if (tbx1.Text != "" && tbx2.Text != "" &&
                tbx3.Text != "" && tbxMedia.Text != "")
            {
                try
                {
                    ntLDI = double.Parse(tbx1.Text);
                    ntLS = double.Parse(tbx2.Text);
                    ntM = double.Parse(tbx3.Text);
                    MNEA = double.Parse(tbxMedia.Text);

                    if (ntLDI >= 1 && ntLDI <= 10
                        && ntLS >= 1 && ntLS <= 10 
                        && ntM >= 1 && ntM <= 10
                        && MNEA >= 1 && MNEA <= 10)
                    {
                        MNDP = (ntLDI + ntLS + ntM) / 3;
                        MC = 0.6 * MNDP + 0.4 * MNEA;
                        tbxRezultat.Text = $"{MC:F2}";
                    }
                    else { MessageBox.Show("Introduceti date corecte !"); }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                MessageBox.Show("Introduceti valori !");
            }

            tbx1.Clear();
            tbx2.Clear();
            tbx3.Clear();
            tbxMedia.Clear();
        }
    }
}
