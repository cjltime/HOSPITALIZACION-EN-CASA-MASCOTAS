using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetCare.App.Dominio;

namespace PetCare.App.Persistencia
{
    public class RepositorioHistoriaClinica : IRepositorioHistoriaClinica
    {
        private readonly AppContext _appContext;
        public RepositorioHistoriaClinica(AppContext appContext)
        {
            _appContext = appContext;
        } 
        HistoriaClinica IRepositorioHistoriaClinica.AddHistoriaClinica(HistoriaClinica historiaClinica)
        {
            var HistoriaClinicaAdicionada = _appContext.HistoriasClinicas.Add(historiaClinica);
            _appContext.SaveChanges();
            return HistoriaClinicaAdicionada.Entity;
        }  
        IEnumerable<HistoriaClinica> IRepositorioHistoriaClinica.GetAllHistoriasClinicas()
        {
            return _appContext.HistoriasClinicas ;
        }  
        HistoriaClinica IRepositorioHistoriaClinica.UpdateHistoriaClinica(HistoriaClinica historiaClinica)
        {
            var HistoriaClinicaEncontrada = _appContext.HistoriasClinicas.FirstOrDefault(p => p.Id == historiaClinica.Id);
            if (HistoriaClinicaEncontrada != null)
            {
                HistoriaClinicaEncontrada.FechaRegistro = historiaClinica.FechaRegistro;
                HistoriaClinicaEncontrada.HistoriaMascota = historiaClinica.HistoriaMascota;
                HistoriaClinicaEncontrada.MedicamentosPermanentes = historiaClinica.MedicamentosPermanentes;
                _appContext.SaveChanges();
            }
            return HistoriaClinicaEncontrada;
        }   
    }
}