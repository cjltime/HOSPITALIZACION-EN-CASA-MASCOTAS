using System.Data.Common;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using PetCare.App.Dominio;

using System.Collections.Generic;
using PetCare.App.Persistencia;


namespace PetCare.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        
              
        public DbSet<Veterinario> Veterinarios {get;set;}
        public DbSet<Mascota> Mascotas {get;set;}
        public DbSet<Propietario> Propietarios {get;set;}
        public DbSet<HistoriaClinica> HistoriasClinicas {get; set;}
        public DbSet<Visita> Visitas {get; set;}

     
        

///el metodo OnCofiguring es el que permite la coneccion con la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  
        {       
            if(!optionsBuilder.IsConfigured) 
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =PetCareDataCJL1");
            }
        } 
    }
}