using System.Collections.Generic;
using PetCare.App.Dominio;

namespace PetCare.App.Persistencia

{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllPets();
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascota(int idMascota);
        Mascota GetMascota(int idMascota);
       
    }

}