using System.Collections.Generic;
using PetCare.App.Dominio;

namespace PetCare.App.Persistencia

{
    public interface IRepositorioVeterinario
    {
        
        IEnumerable<Veterinario> GetAllVeterinarians();
        Veterinario AddVeterinario(Veterinario veterinario);
        Veterinario UpdateVeterinario(Veterinario veterinario, int veterinarioOriginal);
        void DeleteVeterinario(int idVeterinario);
        Veterinario GetVeterinario(int idVeterinario);

    }

}