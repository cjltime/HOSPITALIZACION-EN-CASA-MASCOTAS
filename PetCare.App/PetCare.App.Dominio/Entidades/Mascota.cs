using System;
namespace PetCare.App.Dominio
{
    public class Mascota
    {
        public int  Id {get;set;} 
        public string Nombre {get;set;}
        public string raza {get; set;}
        public bool EstadDeSalud {get; set;}
        public string Ciudad {get; set;}
        public string Nacimiento {get; set;}
        public GeneroMascota GeneroMascota{get;set;}
        public HistoriaClinica HistoriaClinica{get;set;}
        public Visita Visita{get;set;}
        public Propietario Propietario{get;set;}
    }
}