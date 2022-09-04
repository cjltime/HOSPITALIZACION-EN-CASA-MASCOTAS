using System.Collections.Generic;
using System.Linq;
using PetCare.App.Dominio;

namespace PetCare.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {   
        private readonly AppContext _appContext;
        
        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }

        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
        {
            var VeterinarioAdicionado = _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            
            return VeterinarioAdicionado.Entity;
        }

        void IRepositorioVeterinario.DeleteVeterinario(int idVeterinario)
        {
            var VeterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(p => p.Id == idVeterinario);
            if (VeterinarioEncontrado == null)
                return;
            _appContext.Veterinarios.Remove(VeterinarioEncontrado);
            _appContext.SaveChanges();
        }
               
        Veterinario IRepositorioVeterinario.GetVeterinario(int idVeterinario)
        {
            return _appContext.Veterinarios.FirstOrDefault(p => p.Id == idVeterinario);
        }
        IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinarios()
        {
            return _appContext.Veterinarios;
        }
        Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario veterinario, int idVeterinarioOriginal)
        {
            var VeterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(p => p.Id == idVeterinarioOriginal);
            if (VeterinarioEncontrado != null)
            {
                VeterinarioEncontrado.Nombre = veterinario.Nombre;
                VeterinarioEncontrado.Apellidos = veterinario.Apellidos;
                VeterinarioEncontrado.NumeroTelefono = veterinario.NumeroTelefono;
                VeterinarioEncontrado.Genero = veterinario.Genero;
                VeterinarioEncontrado.Correo = veterinario.Correo;
                VeterinarioEncontrado.TarjetaProfesional = veterinario.TarjetaProfesional;
                VeterinarioEncontrado.Especialidad = veterinario.Especialidad;
                
                _appContext.SaveChanges();
            }
            return VeterinarioEncontrado;
        }

    }
}