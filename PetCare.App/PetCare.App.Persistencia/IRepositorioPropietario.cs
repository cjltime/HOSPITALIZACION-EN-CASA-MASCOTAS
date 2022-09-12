using System.Collections.Generic;


namespace PetCare.App.Persistencia
{

    public interface IRepositorioPropietario
    {
        IEnumerable<Propietario> GetAllPropietarios();
        Propietario AddPropietario(Propietario propietario);
        Propietario UpdatePropietario(Propietario propietario);
        void DeletePropietario(int idMascota);
        Propietario GetPropietario(int idMascota);


    }
}