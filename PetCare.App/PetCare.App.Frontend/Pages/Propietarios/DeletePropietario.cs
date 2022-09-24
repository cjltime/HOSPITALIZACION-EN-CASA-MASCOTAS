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
    public class DeletePropietarioModel : PageModel
    {
        private readonly IRepositorioPropietario    repositorioPropietarios;
        [BindProperty]
        
        public Propietario Propietario {get;set;}
        public DeletePropietarioModel()
        {
            this.repositorioPropietarios=new RepositorioPropietario(new PetCare.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? propietarioId)
        {
            if(propietarioId.HasValue)
            {
            Propietario=repositorioPropietarios.GetPropietario(propietarioId.Value);
            }
            else
            {
                Propietario=new Propietario();
            }
            if(Propietario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
        public IActionResult OnPost()
        {
            if(Propietario.Id>0)
            {
            Propietario=repositorioPropietarios.UpdatePropietario(Propietario);
            repositorioPropietarios.DeletePropietario(Propietario.Id);
        
            }
            else
            {
                repositorioPropietarios.AddPropietario(Propietario);
            }
            return Page();
        }
    }
}