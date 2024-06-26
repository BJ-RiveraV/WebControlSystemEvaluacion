using Data.Data.Seed;
using Data.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasIndex(p => p.NumeroDocumento).IsUnique();
            modelBuilder.Entity<Usuario>().HasIndex(p => p.Correo).IsUnique();

            modelBuilder.ApplyConfiguration(new DepartamentosSeed());
            modelBuilder.ApplyConfiguration(new Provincia_Seed());


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Usuario> Users { get; set; }

        public DbSet<Departamento> Departamentos { get; set; }

        public DbSet<Provincia> Provincias { get; set; }
    }
}
