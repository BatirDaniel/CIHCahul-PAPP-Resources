using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Varianta_1.Models.Entities;
using Varianta_1.Pages;

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
        public Client? GetClientById(string id)
        {
            return Clienti.FirstOrDefault(p => p.CodClient == id);
        }
        public void AddClient(Client client)
        {
            Clienti.Add(client);
            SaveChanges();
        }

        public void UpdateClient(Client client)
        {
            Clienti.Update(client);
            SaveChanges();
        }

        public void DeleteClient(Client client)
        {
            Clienti.Remove(client);
            SaveChanges();
        }

        //Handling order data
        public ObservableCollection<Comanda> GetOrders()
        {
            var comenzi = new ObservableCollection<Comanda>(Comenzi.ToList());
            return comenzi;
        }

        public Comanda? GetComandaById(string id)
        {
            return Comenzi.FirstOrDefault(p => p.CodComanda == id);
        }
        public void AddComanda(Comanda comanda)
        {
            Comenzi.Add(comanda);
            SaveChanges();
        }

        public void UpdateClient(Comanda comanda)
        {
            Comenzi.Update(comanda);
            SaveChanges();
        }

        public void DeleteClient(Comanda comanda)
        {
            Comenzi.Remove(comanda);
            SaveChanges();
        }
    }
}
