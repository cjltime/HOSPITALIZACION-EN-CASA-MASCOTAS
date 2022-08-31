using System.Collections.Generic;
using PetCare.App.Dominio;

namespace PetCare.App.Persistencia

{
    public interface IRepositorioMascota
    {
        IEnumerable<HistoriaClinica> GetAllStories();
        HistoriaClinica AddHistoriaClinica(HistoriaClinica historiaClinica);
        HistoriaClinica UpdateHistoriaClinica(HistoriaClinica historiaClinica);
        void DeleteHistoriaClinica(int idHistoriaClinica);
        HistoriaClinica GetHistoriaClinica(int idHistoriaClinica);

        IEnumerable<Mascota> GetAllPets();
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascota(int idMascota);
        Mascota GetMascota(int idMascota);

        IEnumerable<Persona> GetAllPeople();
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        void DeletePersona(int idPersona);
        Persona GetPersona(int idPersona);

        IEnumerable<SignoVital> GetAllVitalSings();
        SignoVital AddSignoVital(SignoVital signoVital);
        SignoVital UpdateSignoVital(SignoVital signoVital);
        void DeleteSignoVital(int idSignoVital);
        SignoVital GetSignoVital(int idSignoVital);

        IEnumerable<Visita> GetAllVisits();
        Visita AddVisita(Visita visita);
        Visita UpdateVisita(Visita visita);
        void DeleteVisita(int idVisita);
        Visita GetVisita(int idVisita);

    }

}