using PetCare.App.Dominio;
using PetCare.App.Persistencia;

namespace PetCare.App.Consola
{
    class program
    {
        private static IRepositorioMascota _repoMascota= new RepositorioMascota(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World Entity framework! ");
            AddMascota();
            
        }

        private static void AddMascota()
        {
            var mascota = new Mascota{
                raza="Pincher",
                Nombre="Lana",
                EstadDeSalud=true,
                DireccionPet="carrea 2 call 1",
                Latitud=02333,
                Longitud=98744,
                Ciudad="Bucaramanga",
                Nacimiento="01-12-2022"
 
            };
            Console.WriteLine("\nLa Mascota :"+mascota.Nombre+" se adiciono  \n");
            _repoMascota.AddMascota(mascota);
            
        }
    }
}

// See https://aka.ms/new-console-template for more information

