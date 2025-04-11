using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    internal class CommandeConfiguration : IEntityTypeConfiguration<Commande>
    {
        public void Configure(EntityTypeBuilder<Commande> builder)
        {
            builder.HasKey(e => new { e.DateCommande, e.ClientFK, e.JouetFK });
            builder.HasOne(e => e.Client).WithMany(e => e.Commande).HasForeignKey(e => e.ClientFK);
            builder.HasOne(e => e.JouetEducatif).WithMany(e => e.Commande).HasForeignKey(e => e.JouetFK);
        }
    }
}
