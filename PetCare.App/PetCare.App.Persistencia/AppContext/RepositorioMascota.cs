using System.Collections.Generic;

using System.Linq;

using PetCare.App.Dominio;

namespace PetCare.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {   
        private readonly AppContext _appContext;
        
        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }

    }
}