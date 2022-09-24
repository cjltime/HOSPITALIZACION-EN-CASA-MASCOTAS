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
    public class DetailsPropietarioModel : PageModel
    {
        private readonly IRepositorioPropietario    repositorioPropietarios;
        public Propietario Propietario {get;set;}
        public DetailsPropietarioModel()
        {
            this.repositorioPropietarios=new RepositorioPropietario(new PetCare.App.Persistencia.AppContext());
            
        }
        public IActionResult OnGet(int propietarioId)
        {
            Propietario=repositorioPropietarios.GetPropietario(propietarioId);
            
            
            if(Propietario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
        

    }
}
