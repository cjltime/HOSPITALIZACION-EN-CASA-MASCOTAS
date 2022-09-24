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
    public class EditVModel : PageModel
    {
        private readonly IRepositorioMascota    repositorioMascotas;
        private readonly IRepositorioPropietario    repositorioPropietarios;
        private readonly IRepositorioVisita repositorioVisitas;

        [BindProperty]
        
        public Visita Visita {get;set;}
        public EditVModel()
        {
            this.repositorioVisitas=new RepositorioVisita(new PetCare.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? visitaId)
        {
            if(visitaId.HasValue)
            {
            Visita=repositorioVisitas.GetVisita(visitaId.Value);
            }
            else
            {
                Visita=new Visita();
            }
            if(Visita==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
        public IActionResult OnPost()
        {
            if(Visita.Id>0)
            {
            Visita=repositorioVisitas.UpdateVisita(Visita);
            
        
            }
            else
            {
                repositorioVisitas.AddVisita(Visita);
            }
            return Page();
        }
    }
}