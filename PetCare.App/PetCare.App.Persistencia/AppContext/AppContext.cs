using Microsoft.EntityFrameworkCore;
using PetCare.App.Dominio;

namespace PetCare.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<HistoriaClinica> HistoriasClinicas { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<SignoVital> SignosVitales { get; set; }
        public DbSet<Visita> Visitas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =PetCareData");
            }
        }
    }
}