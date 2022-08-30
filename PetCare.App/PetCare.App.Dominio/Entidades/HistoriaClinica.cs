using System;
namespace PetCare.App.Dominio
{
    public class HistoriaClinica
    {
        public int  Id {get;set;} 
        public System.Collections.Generic.List<Visita> Visitas {get;set;} 

    }
}