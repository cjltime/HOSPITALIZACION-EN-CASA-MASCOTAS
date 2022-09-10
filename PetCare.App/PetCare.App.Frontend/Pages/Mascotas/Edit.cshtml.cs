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
    public class EditModel : PageModel
    {
        private readonly IRepositorioMascota    repositorioMascotas;
        [BindProperty]
        
        public Mascota Mascota {get;set;}
        public EditModel()
        {
            this.repositorioMascotas=new RepositorioMascota(new PetCare.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? mascotaId)
        {
            if(mascotaId.HasValue)
            {
            Mascota=repositorioMascotas.GetMascota(mascotaId.Value);
            }
            else
            {
                Mascota=new Mascota();
            }
            if(Mascota==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
        public IActionResult OnPost()
        {
            if(Mascota.Id>0)
            {
            Mascota=repositorioMascotas.UpdateMascota(Mascota);
            }
            else
            {
                repositorioMascotas.AddMascota(Mascota);
            }
            return Page();
        }
    }
}