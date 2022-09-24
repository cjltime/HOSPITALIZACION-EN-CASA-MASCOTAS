using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PetCare.App.Dominio;
using PetCare.App.Persistencia;

namespace PetCare.App.Frontend.Pages
{
    public class ListPModel : PageModel
    {
        
        private readonly IRepositorioMascota    repositorioMascotas;
        public IEnumerable<Mascota> Mascotas {get;set;}

        public ListPModel()
        {
            this.repositorioMascotas=new RepositorioMascota(new PetCare.App.Persistencia.AppContext());
        }

        public void OnGet(string filtroBusqueda)
        {
            
            Mascotas=repositorioMascotas.GetAllPets();
        }
    }
}
