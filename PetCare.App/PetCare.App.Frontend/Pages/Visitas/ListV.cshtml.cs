using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PetCare.App.Dominio;
using PetCare.App.Persistencia;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;


namespace PetCare.App.Frontend.Pages
{
    [Authorize]
    public class ListVModel : PageModel
    {

        private readonly IRepositorioVisita repositorioVisitas;
        private readonly IRepositorioMascota    repositorioMascotas;
        private readonly IRepositorioPropietario    repositorioPropietarios;
        public IEnumerable<Visita> Visitas {get;set;}

            public ListVModel()
        {
            this.repositorioVisitas=new RepositorioVisita(new PetCare.App.Persistencia.AppContext());
            this.repositorioPropietarios=new RepositorioPropietario(new PetCare.App.Persistencia.AppContext());
        }

        public void OnGet(string filtroBusqueda)
        {
            
            Visitas=repositorioVisitas.GetAllVisitas();
        }
    }
}
