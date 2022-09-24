using System;
namespace PetCare.App.Dominio
{
    public class Visita
    {
      public int  Id {get;set;} 
      public DateTime FechaVisita{get;set;}
      public String Recomendaciones{set;get;}
      public string Diagnostico{get;set;}
      public string Medicamentos {get;set;}  
      public Veterinario Veterinario{get;set;}
      public System.Collections.Generic.List<SignoVital> SignosVitales {get;set;}  
    }
}