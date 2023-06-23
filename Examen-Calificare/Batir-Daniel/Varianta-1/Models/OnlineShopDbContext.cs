using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Linq;
using Varianta_1.Models.Entities;

namespace Varianta_1.Models
{
    public class OnlineShopDbContext : DbContext
    {
        public DbSet<Client>? Clienti { get; set; }
        public DbSet<Comanda>? Comenzi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = OnlineShop.db").EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasKey(c => c.CodClient);

            modelBuilder.Entity<Comanda>()
                .HasKey(c => c.CodComanda);

            modelBuilder.Entity<Comanda>()
                .HasOne(c => c.Client)
                .WithMany()
                .HasForeignKey(c => c.CodClient);
        }


        //Handling customer data

        public ObservableCollection<Client> GetClients()
        {
            var clients = new ObservableCollection<Client>(Clienti.ToList());
            return clients;
        }
        public Client? GetClientById(int id)
        {
            return Clienti.FirstOrDefault(p => p.CodClient == id);
        }

        //Handling order data
        public ObservableCollection<Comanda> GetOrders()
        {
            var comenzi = new ObservableCollection<Comanda>(Comenzi.ToList());
            return comenzi;
        }

        public Comanda? GetComandaById(int id)
        {
            return Comenzi.FirstOrDefault(p => p.CodComanda == id);
        }
    }
}
