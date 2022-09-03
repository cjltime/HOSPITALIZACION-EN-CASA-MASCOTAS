using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetCare.App.Dominio;

namespace PetCare.App.Persistencia
{
    public interface IRepositorioVisita
    {
        IEnumerable<Visita> GetAllVisitas();
        Visita AddVisita(Visita visita);
        Visita UpdateVisita(Visita visita);
        void DeleteVisita(int idVisita);
        Visita GetVisita(int idVisita);   
    }
}