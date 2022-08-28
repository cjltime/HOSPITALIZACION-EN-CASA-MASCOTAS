using System;
namespace HospiEnCasa.App.Dominio


{
    public class HistoriaClinica
    {
        public int  Id {get;set;} 
        public string Diagnostico {get;set;}
        public string Entorno {get;set;}
        public string Observaciones {get;set;}
    }
}