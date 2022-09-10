using System.Collections.Generic;

using System.Linq;

using PetCare.App.Dominio;

namespace PetCare.App.Persistencia
{
    public class RepositorioPropietario : IRepositorioPropietario
    {
       
        private readonly AppContext _appContext;
        public RepositorioPropietario(AppContext appContext)
        {
            _appContext = appContext;
        } 
        
        Propietario IRepositorioPropietario.AddPropietario(Propietario propietario)
        {
            var PropietarioAdicionado = _appContext.Propietarios.Add(propietario);
            _appContext.SaveChanges();
            
            return PropietarioAdicionado.Entity;
        }
        IEnumerable<Propietario> IRepositorioPropietario.GetAllPropietarios()
        {
            return _appContext.Propietarios ;
        }
        Propietario IRepositorioPropietario.UpdatePropietario(Propietario propietario)
        {

            var PropietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p => p.Id == propietario.Id);
            if (PropietarioEncontrado != null)
            {
                PropietarioEncontrado.Nombre = propietario.Nombre;
                PropietarioEncontrado.Apellidos=propietario.Apellidos;
                PropietarioEncontrado.NumeroTelefono=propietario.NumeroTelefono;
                PropietarioEncontrado.Genero=propietario.Genero;
                PropietarioEncontrado.Correo=propietario.Correo;
                PropietarioEncontrado.Direccion=propietario.Direccion;
                PropietarioEncontrado.Edad=propietario.Edad;
                _appContext.SaveChanges();
            }
            return PropietarioEncontrado;
        }
                
        void IRepositorioPropietario.DeletePropietario(int idPropietario)
        {
            var PropietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p => p.Id == idPropietario);
            if (PropietarioEncontrado == null)
                return;
            _appContext.Propietarios.Remove(PropietarioEncontrado);
            _appContext.SaveChanges();
        }
        Propietario IRepositorioPropietario.GetPropietario(int idPropietario)
        {
            return _appContext.Propietarios.FirstOrDefault(p => p.Id == idPropietario);
        }

    }
}