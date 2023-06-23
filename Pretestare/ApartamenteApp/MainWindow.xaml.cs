using ApartamenteApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

namespace ApartamenteApp
{
    public partial class MainWindow : Window
    {
        private ApartamenteContext _context;

        private ObservableCollection<Agent> agenti;
        public ObservableCollection<Agent> Agenti
        {
            get { return agenti; }
            set { agenti = value; }
        }
        private ObservableCollection<Apartament> apartamente;
        public ObservableCollection<Apartament> Apartament
        {
            get { return apartamente; }
            set { apartamente = value; }
        }
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new Agent();
            _context = new ApartamenteContext();
            _context.Database.EnsureCreated();

            RefreshAgenti();
            RefreshApartamente();
        }

        private void RefreshApartamente()
        {
            dgApartamente.ItemsSource = _context.GetApartamente();
        }

        private void RefreshAgenti()
        {
            dgAgenti.ItemsSource = _context.GetAgenti();
        }

        private void btnAddAgent_Click(object sender, RoutedEventArgs e)
        {
            gbAddAgenti.Visibility = Visibility.Visible;
            gbAddApartamente.Visibility = Visibility.Collapsed;
            gbDisplayAgenti.Visibility = Visibility.Collapsed;
            gbDisplayApartamente.Visibility = Visibility.Collapsed;


        }

        private void btnDisplayAgent_Click(object sender, RoutedEventArgs e)
        {
            gbAddAgenti.Visibility = Visibility.Collapsed;
            gbAddApartamente.Visibility = Visibility.Collapsed;
            gbDisplayAgenti.Visibility = Visibility.Visible;
            gbDisplayApartamente.Visibility = Visibility.Collapsed;

        }

        private void btnAddApartament_Click(object sender, RoutedEventArgs e)
        {
            gbAddAgenti.Visibility = Visibility.Collapsed;
            gbAddApartamente.Visibility = Visibility.Visible;
            gbDisplayAgenti.Visibility = Visibility.Collapsed;
            gbDisplayApartamente.Visibility = Visibility.Collapsed;

        }

        private void btnOperationOne_Click(object sender, RoutedEventArgs e)
        {
            gbAddAgenti.Visibility = Visibility.Collapsed;
            gbAddApartamente.Visibility = Visibility.Collapsed;
            gbDisplayAgenti.Visibility = Visibility.Collapsed;
            gbDisplayApartamente.Visibility = Visibility.Collapsed;
        }

        private void btnOperationTwo_Click(object sender, RoutedEventArgs e)
        {
            gbAddAgenti.Visibility = Visibility.Collapsed;
            gbAddApartamente.Visibility = Visibility.Collapsed;
            gbDisplayAgenti.Visibility = Visibility.Collapsed;
            gbDisplayApartamente.Visibility = Visibility.Collapsed;
        }

        private void btnOperationThree_Click(object sender, RoutedEventArgs e)
        {
            gbAddAgenti.Visibility = Visibility.Collapsed;
            gbAddApartamente.Visibility = Visibility.Collapsed;
            gbDisplayAgenti.Visibility = Visibility.Collapsed;
            gbDisplayApartamente.Visibility = Visibility.Collapsed;
        }

        private void btnCancelAgent_Click(object sender, RoutedEventArgs e)
        {
            tbxNume.Text = "";
            tbxPrenume.Text = "";
            tbxVarsta.Text = "";
            tbxTelefon.Text = "";

            tbxNume.Focus();
        }

        private void btnSaveAgent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (btnSaveAgent.Content != "Edit")
                {
                    using (var context = new ApartamenteContext())
                    {
                        var agent = new Agent
                        {
                            Nume = tbxNume.Text,
                            Prenume = tbxPrenume.Text,
                            Varsta = int.Parse(tbxVarsta.Text),
                            Telefon = tbxTelefon.Text
                        };
                        _context.AddAgent(agent);
                        MessageBox.Show("The agent has been successfully added!");

                        tbxNume.Text = "";
                        tbxPrenume.Text = "";
                        tbxVarsta.Text = "";
                        tbxTelefon.Text = "";

                        tbxNume.Focus();

                        RefreshAgenti();
                    }
                }
                else
                {
                    Agent? agent = dgAgenti.SelectedItem as Agent;
                    if (agent == null)
                    {
                        return;
                    }
                    if (_context.GetAgentById(agent.CodAgent) != null)
                    {
                        agent.Nume = tbxNume.Text;
                        agent.Prenume = tbxPrenume.Text;
                        agent.Varsta = int.Parse(tbxVarsta.Text);
                        agent.Telefon= tbxTelefon.Text);

                        _context.UpdateAgent(agent);
                        RefreshAgenti();

                        MessageBox.Show("The agent has been edited successfully!");

                        gbAddAgenti.Visibility = Visibility.Collapsed;
                        gbDisplayAgenti.Visibility = Visibility.Visible;
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Eroare! Date introduse incorecte!");
            }
        }

        private void btnCancelApartament_Click(object sender, RoutedEventArgs e)
        {
            tbxEtaj.Text = "";
            tbxNrCamere.Text = "";
            tbxVarsta.Text = "";
            tbxTelefon.Text = "";
            cbNumeAgent.Text = "";

            tbxNume.Focus();

        }

        private void btnSaveApartament_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (btnSaveApartament.Content != "Edit")
                {
                    using (var context = new ApartamenteContext())
                    {
                        Agent agent = new Agent();
                        var apartament = new Apartament
                        {
                            Etaj = int.Parse(tbxEtaj.Text),
                            nrCamere = int.Parse(tbxNrCamere.Text),
                            Pret = double.Parse(tbxVarsta.Text),
                            metriPatrati = int.Parse(tbxTelefon.Text),
                        };
                        _context.AddAgent(agent);
                        MessageBox.Show("The apartament has been successfully added!");

                        tbxEtaj.Text = "";
                        tbxNrCamere.Text = "";
                        tbxVarsta.Text = "";
                        tbxTelefon.Text = "";
                        cbNumeAgent.Text = "";

                        tbxNume.Focus();

                        RefreshAgenti();
                    }
                }
                else
                {
                    Apartament? apartament = dgApartamente.SelectedItem as Apartament;
                    if (apartament == null)
                    {
                        return;
                    }
                    if (_context.GetApartamentById(apartament.CodApartament) != null)
                    {
                        apartament.Etaj = int.Parse(tbxEtaj.Text);
                        apartament.nrCamere = int.Parse(tbxNrCamere.Text);
                        apartament.Pret = double.Parse(tbxVarsta.Text);
                        apartament.metriPatrati = int.Parse(tbxTelefon.Text);

                        _context.UpdateApartament(apartament);
                        RefreshAgenti();

                        MessageBox.Show("The apartament has been edited successfully!");

                        gbAddApartamente.Visibility = Visibility.Collapsed;
                        gbDisplayApartamente.Visibility = Visibility.Visible;
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Eroare! Date introduse incorecte!");
            }
        }
    }
}
