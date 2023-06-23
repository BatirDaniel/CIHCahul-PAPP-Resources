using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Varianta_1.Models;
using Varianta_1.RellayCommand;

namespace Varianta_1.ViewModels.Comanda
{
    public class ComandaViewModel : INotifyPropertyChanged
    {
        public Models.Entities.Comanda? selectedComanda;

        public ObservableCollection<Models.Entities.Comanda?> Orders { get; set; }
        private OnlineShopDbContext _onlineShopDbContext;
        public OnlineShopDbContext OnlineShopDbContext { get; set; }
        private List<Models.Entities.Client> _clients;
        public List<Models.Entities.Client> Clients
        {
            get { return _clients; }
            set
            {
                _clients = value;
                OnPropertyChanged(nameof(Clients));
            }
        }
        private RelayCommand? addCommand;
        public ICommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Models.Entities.Comanda comanda = new Models.Entities.Comanda();
                      OnlineShopDbContext.Comenzi.Add(SelectedComanda);
                      Orders = new ObservableCollection<Models.Entities.Comanda?>(OnlineShopDbContext.Comenzi.ToList());
                      SelectedComanda = comanda;
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

        public Models.Entities.Comanda? SelectedComanda
        {
            get { return selectedComanda; }
            set
            {
                selectedComanda = value;
                OnPropertyChanged("SelectedClient");
            }
        }

        public ComandaViewModel()
        {
            SelectedComanda = new Models.Entities.Comanda();

            _onlineShopDbContext = new OnlineShopDbContext();

            _clients = _onlineShopDbContext.GetClients().ToList();

            OnlineShopDbContext = new OnlineShopDbContext();

            Orders = new ObservableCollection<Models.Entities.Comanda?>();
        }
    }
}
