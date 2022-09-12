using System.Collections.Generic;


namespace PetCare.App.Persistencia
{

    public interface IRepositorioSignoVital
    {
        IEnumerable<SignoVital> GetAllSignoVital();
        SignoVital AddSignoVital(SignoVital signoVital);
        SignoVital UpdateSignoVital(SignoVital signoVital);
        void DeleteSignoVital(int idMascota);
        SignoVital GetSignoVital(int idMascota);


    }
}