using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetCare.App.Dominio;

namespace PetCare.App.Persistencia
{
    public interface IRepositorioHistoriaClinica
    {
        
        IEnumerable<HistoriaClinica> GetAllHistoriasClinicas();
        HistoriaClinica AddHistoriaClinica(HistoriaClinica historiaClinica);
        HistoriaClinica UpdateHistoriaClinica(HistoriaClinica historiaClinica);
        //void DeleteMascota(int idMascota);
        //void DeleteHistoriaClinica(int idHistoriaClinica);
        // Mascota GetMascota(int idMascota);
        //HistoriaClinica GetHistoriaClinica(int idHistoriaClinica);  
    }
}