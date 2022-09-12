using System.Collections.Generic;
using System.Linq;
using PetCare.App.Dominio;



namespace PetCare.App.Persistencia
{
    public class  RepositorioPropietario:IRepositorioPropietario
    {
        /// <summary>
        /// Referencia al contexto de Propietario
        /// </summary>

        private readonly AppContext _appContext;
        /// <summary>
        /// metodo constructor utiliza
        /// Inyeccion de deoencias oara indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//

        public RepositorioPropietario(AppContext appContext)
        {
            _appContext=appContext;
        }

        Propietario IRepositorioPropietario.AddPropietario(Propietario propietario)
        {
            var propietarioAdicionado = _appContext.Propietarios.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;
        }

        Propietario IRepositorioPropietario.DeletePropietario(Propietario propietario)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p => p.Id==idMascota );
            if (propietarioEncontrado==null)
            return;
            _appContext.Propietarios.Remove(propietarioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Propietario> IRepositorioPropietario.GetAllPropietarios()
        {
            return _appContext.Propietarios;
        }
        
        Propietario IRepositorioPropietario.GetPropietario(int idMascota)
        {
            return _appContext.Propietarios.FirstOrDefault(p => p.Id==idMascota );
        }

        Propietario IRepositorioPropietario.UpdatePropietario(Propietario propietario)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p => p.Id==mascota.id );
            if (propietarioEncontrado !=null)
            {
                propietarioEncontrado.Direccion=propietario.Direccion;
                propietarioEncontrado.Edad=propietario.Edad;

                _appContext.SaveChanges();
                
            }
            return propietarioEncontrado;
        }


    }
}