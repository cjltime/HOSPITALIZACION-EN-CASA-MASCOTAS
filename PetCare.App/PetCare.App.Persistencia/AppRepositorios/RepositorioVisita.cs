using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetCare.App.Dominio;

namespace PetCare.App.Persistencia
{
    public class RepositorioVisita : IRepositorioVisita
    {
       private readonly AppContext _appContext;
        public RepositorioVisita(AppContext appContext)
        {
            _appContext = appContext;
        } 
        Visita IRepositorioVisita.AddVisita(Visita visita)
        {
            var VisitaAdicionada = _appContext.Visitas.Add(visita);
            _appContext.SaveChanges();
            
            return VisitaAdicionada.Entity;
        } 
        IEnumerable<Visita> IRepositorioVisita.GetAllVisitas()
        {
            return _appContext.Visitas ;
        }
        Visita IRepositorioVisita.UpdateVisita(Visita visita)
        {

            var VisitaEncontrada = _appContext.Visitas.FirstOrDefault(p => p.Id == visita.Id);
            if (VisitaEncontrada != null)
            {
                VisitaEncontrada.FechaVisita = visita.FechaVisita;
                VisitaEncontrada.Recomendaciones=visita.Recomendaciones;
                VisitaEncontrada.Diagnostico=visita.Diagnostico;
                VisitaEncontrada.Medicamentos=visita.Medicamentos;
                VisitaEncontrada.Veterinario=visita.Veterinario;
                _appContext.SaveChanges();
            }
            return VisitaEncontrada;
        }
        void IRepositorioVisita.DeleteVisita(int idVisita)
        {
            var VisitaEncontrada = _appContext.Visitas.FirstOrDefault(p => p.Id == idVisita);
            if (VisitaEncontrada == null)
                return;
            _appContext.Visitas.Remove(VisitaEncontrada);
            _appContext.SaveChanges();
        }
        Visita IRepositorioVisita.GetVisita(int idVisita)
        {
            return _appContext.Visitas.FirstOrDefault(p => p.Id == idVisita);
        }

    }
}