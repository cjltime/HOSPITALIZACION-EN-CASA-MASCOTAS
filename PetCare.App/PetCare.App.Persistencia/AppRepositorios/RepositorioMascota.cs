using System.Collections.Generic;

using System.Linq;

using PetCare.App.Dominio;

namespace PetCare.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {   /// <summary>
        /// Referencia al contexto de Mascota
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }
        Mascota IRepositorioMascota.AddMascota(Mascota mascota)
        {
            var MascotaAdicionada = _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            
            return MascotaAdicionada.Entity;
        }
        void IRepositorioMascota.DeleteMascota(int idMascota)
        {
            var MascotaEncontrada = _appContext.Mascotas.FirstOrDefault(p => p.Id == idMascota);
            if (MascotaEncontrada == null)
                return;
            _appContext.Mascotas.Remove(MascotaEncontrada);
            _appContext.SaveChanges();
        }
        IEnumerable<Mascota> IRepositorioMascota.GetAllPets()
        {
            return _appContext.Mascotas ;
        }
        public IEnumerable<Mascota> GetAllMascotas_()
        {
            return _appContext.Mascotas ;
        }
               
        Mascota IRepositorioMascota.GetMascota(int idMascota)
        {
            return _appContext.Mascotas.FirstOrDefault(p => p.Id == idMascota);
        }
        
        Mascota IRepositorioMascota.UpdateMascota(Mascota mascota)
        {

            var MascotaEncontrada = _appContext.Mascotas.FirstOrDefault(p => p.Id == mascota.Id);
            if (MascotaEncontrada != null)
            {
                MascotaEncontrada.raza = mascota.raza;
                MascotaEncontrada.Nombre = mascota.Nombre;
                MascotaEncontrada.EstadDeSalud = mascota.EstadDeSalud;
                MascotaEncontrada.Ciudad = mascota.Ciudad;
                MascotaEncontrada.Nacimiento = mascota.Nacimiento;
                MascotaEncontrada.GeneroMascota = mascota.GeneroMascota;
                
                _appContext.SaveChanges();
            }
            return MascotaEncontrada;
        }

    }
}