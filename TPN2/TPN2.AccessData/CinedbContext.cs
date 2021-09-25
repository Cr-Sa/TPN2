using Microsoft.EntityFrameworkCore;
using TPN2.Domain.Entities;
using TPN2.Domain.EntitiesConfiguration;

namespace TPN2.AccessData
{
    public class TemplateDbContext : DbContext
    {
        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options)
        { 
        
        }

        public DbSet<Peliculas> Peliculas { get; set; }
        public DbSet<Funciones> Funciones { get; set; }
        public DbSet<Salas> Salas { get; set; }
        public DbSet<Tickets> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionesConfiguration());
            modelBuilder.ApplyConfiguration(new PeliculasConfiguration());
            modelBuilder.ApplyConfiguration(new SalasConfiguration());
            modelBuilder.ApplyConfiguration(new TicketsConfiguration());
        }

    }
}

