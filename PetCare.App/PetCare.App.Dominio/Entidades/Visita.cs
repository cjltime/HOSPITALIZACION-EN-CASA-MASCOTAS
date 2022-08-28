using System;
namespace HospiEnCasa.App.Dominio
{
    public class Visita
    {
      public int  Id {get;set;} 
      public string FechaVisita{get;set;}
      public String Recomendaciones{set;get;}
      public string Diagnostico{get;set;}
      public string Medicamentos {get;set;}  
      public Veterinario Veterinario{get;set;}
      public SignoVital SignoVital{get;set;}   

    }
}