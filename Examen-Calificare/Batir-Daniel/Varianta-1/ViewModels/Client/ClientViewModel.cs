using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Varianta_1.Models;
using Varianta_1.Models.Entities;
using Varianta_1.RellayCommand;

namespace Varianta_1.ViewModels.Client
{
    public class ClientViewModel : INotifyPropertyChanged
    {
        public Models.Entities.Client? selectedClient;

        private ObservableCollection<Models.Entities.Client> clients;
        public ObservableCollection<Models.Entities.Client> Clients
        {
            get { return clients; }
            set { clients = value; OnPropertyChanged(); }
        }

        public OnlineShopDbContext OnlineShopDbContext { get; set; }

        //Add client command
        private RelayCommand? addCommand { get; set; }
        public ICommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Models.Entities.Client client = new Models.Entities.Client();
                      if (SelectedClient != null)
                      {
                          OnlineShopDbContext.Clienti.Add(SelectedClient);
                          Clients = new ObservableCollection<Models.Entities.Client>(OnlineShopDbContext.GetClients());
                          SelectedClient = client;
                          OnlineShopDbContext.SaveChanges();
                      }
                      else return;
                  }));
            }
        }

        //Remove client command
        private RelayCommand? removeCommand { get; set; }
        public ICommand? RemoveCommand
        {
            get
            {
                return removeCommand ??
                    (removeCommand = new RelayCommand(obj =>
                    {
                        Models.Entities.Client client = SelectedClient as Models.Entities.Client;
                        if (client == null)
                        {
                            return;
                        }

                        Clients.Remove(client);
                        OnlineShopDbContext.Clienti.Remove(client);
                        OnlineShopDbContext.SaveChanges();

                    }));
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public Models.Entities.Client? SelectedClient
        {
            get { return selectedClient; }
            set
            {
                selectedClient = value;
                OnPropertyChanged("SelectedClient");
            }
        }

        public ClientViewModel()
        {
            SelectedClient = new Models.Entities.Client();
            OnlineShopDbContext = new OnlineShopDbContext();
        }
    }
}
