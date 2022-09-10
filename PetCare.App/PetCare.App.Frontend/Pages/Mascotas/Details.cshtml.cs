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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioMascota    repositorioMascotas;
        public Mascota Mascota {get;set;}
        public DetailsModel()
        {
            this.repositorioMascotas=new RepositorioMascota(new PetCare.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int mascotaId)
        {
            Mascota=repositorioMascotas.GetMascota(mascotaId);
            if(Mascota==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}
