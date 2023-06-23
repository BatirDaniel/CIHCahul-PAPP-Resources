using CircleApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace CircleApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<Cerc> cercList = new List<Cerc>();

        private void btnCalculeaza_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double raza = double.Parse(editRaza.Text);
                Cerc cerc = new Cerc(raza);
                cercList.Add(cerc);
                dataGrid.ItemsSource = cercList.ToList();
                editRaza.Text = "";
                editRaza.Focus();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            int countFiguri = 0;
            countFiguri = cercList.Count();

            double minArie = cercList.Min(el => el.arieCerc);
            try
            {
                FileStream stream = new FileStream("result.txt", FileMode.OpenOrCreate);
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Flush();
                    writer.WriteLine($"Aria minima : {minArie:F3}");
                    writer.WriteLine($"Numarul de figuri : {countFiguri}");
                    writer.Close();
                    MessageBox.Show("Datele au fost salvate cu succes !");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
