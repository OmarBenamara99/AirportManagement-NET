using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class Context : DbContext
    {
        
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<JouetEducatif> JouetEducatifs { get; set; }
        public DbSet<JouetEducatifMoteur> JouetEducatifMoteurs { get; set; }
        public DbSet<JouetEducatifCognitif> Jouet { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseLazyLoadingProxies().
                UseSqlServer(this.GetJsonConnectionString("appsettings.json"));
            base.OnConfiguring(optionsBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            

            configurationBuilder.Properties<String>().HaveMaxLength(250);
            base.ConfigureConventions(configurationBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CommandeConfiguration());
            

            modelBuilder.Entity<JouetEducatif>().ToTable("JouetEducatif");
            modelBuilder.Entity<JouetEducatifMoteur>().ToTable("JouetEducatifMoteur");
            modelBuilder.Entity<JouetEducatifCognitif>().ToTable("JouetEducatifCognitif");
            base.OnModelCreating(modelBuilder);
        }
    }
}
