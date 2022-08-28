using System;


namespace HospiEnCasa.App.Dominio
{
    public class SignoVital
    {
           public int Id {get; set;}
           public string FechaHora {get; set;}
           public TipoSigno TipoSigno {get; set;}
           public string Valor {get; set;}

    }
}