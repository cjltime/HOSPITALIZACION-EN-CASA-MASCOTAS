using System;
namespace PetCare.App.Dominio
{
    public class SignoVital
    {
           public int Id {get; set;}
           public DateTime FechaHora {get; set;}
           public TipoSigno TipoSigno {get; set;}
           public string Valor {get; set;}
    }
}