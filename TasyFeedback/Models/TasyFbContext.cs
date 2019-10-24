using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TasyFeedback.Models
{
    public partial class TasyFbContext : DbContext
    {
        public TasyFbContext()
        {
        }

        public TasyFbContext(DbContextOptions<TasyFbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Configuracion> Configuracion { get; set; }
        public virtual DbSet<Error> Error { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Configuracion>(entity =>
            {
                entity.Property(e => e.DirectorioImg).HasMaxLength(250);
            });

            modelBuilder.Entity<Error>(entity =>
            {
                entity.Property(e => e.Funcion).HasMaxLength(50);

                entity.Property(e => e.Img).HasMaxLength(50);

                entity.Property(e => e.Perfil).HasMaxLength(50);
            });
        }
    }
}
