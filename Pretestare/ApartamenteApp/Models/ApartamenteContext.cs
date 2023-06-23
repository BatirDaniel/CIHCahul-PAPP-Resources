using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ApartamenteApp.Models
{
    public class ApartamenteContext : DbContext
    {
        public DbSet<Apartament> Apartamente { get; set; }
        public DbSet<Agent> Agenti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Apartamente.db").EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apartament>()
                .HasKey(a => a.CodApartament);

            modelBuilder.Entity<Agent>()
                .HasKey(a => a.CodAgent);

            modelBuilder.Entity<Apartament>()
                .HasOne(a => a.Agent)
                .WithMany()
                .HasForeignKey(a => a.CodAgent);
        }
        
        //Apartamente

        public ObservableCollection<Apartament> GetApartamente()
        {
            var apartamente = Apartamente.ToList();
            var apartamenteObs = new ObservableCollection<Apartament>(apartamente);
            return apartamenteObs;
        }
        public Apartament? GetApartamentById(int id)
        {
            return Apartamente.FirstOrDefault(a => a.CodApartament == id);
        }
        public void AddApartament(Apartament apartament)
        {
            Apartamente.Add(apartament);
            SaveChanges();
        }

        public void UpdateApartament(Apartament apartament)
        {
            base.Entry(apartament).State = EntityState.Modified;
            SaveChanges();
        }

        public void DeleteCar(Apartament apartament)
        {
            Apartamente.Remove(apartament);
            SaveChanges();
        }

        //Agenti

        public ObservableCollection<Agent> GetAgenti()
        {
            var agenti = Agenti.ToList();
            var agentiObs = new ObservableCollection<Agent>(agenti);
            return agentiObs;
        }
        public Agent? GetAgentById(int id)
        {
            return Agenti.FirstOrDefault(a => a.CodAgent == id);
        }
        public void AddAgent(Agent agent)
        {
            Agenti.Add(agent);
            SaveChanges();
        }

        public void UpdateAgent(Agent agent)
        {
            base.Entry(agent).State = EntityState.Modified;
            SaveChanges();
        }

        public void DeleteCar(Agent agent)
        {
            Agenti.Remove(agent);
            SaveChanges();
        }
    }
}
