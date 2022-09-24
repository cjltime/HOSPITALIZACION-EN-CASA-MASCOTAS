using System.IO.Compression;
using System;
using PetCare.App.Dominio;
using PetCare.App.Persistencia;



namespace PetCare.App.Consola
{
    class program
    {
        private static IRepositorioMascota _repoMascota= new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioPropietario _repoPropietario = new RepositorioPropietario(new Persistencia.AppContext());
        private static IRepositorioHistoriaClinica _repoHistoriaClinica = new RepositorioHistoriaClinica(new Persistencia.AppContext());
        private static IRepositorioVisita _repoVisita = new RepositorioVisita(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World Entity framework! ");
            AddMascota();
            AddVeterinario();
            //BuscarMascota(1);
            //DeleteMascota(2);
            BuscarMascota(2);
            DeleteMascota(3);
            BuscarMascota(3);
            BuscarMascota(68);
            
        }

        private static void AddMascota()
        {
            var mascota = new Mascota{
                raza="Pincher",
                Nombre="Lana",
                EstadDeSalud=true,
                Ciudad="Bucaramanga",
                //Nacimiento="01-12-2022"
 
            };
            Console.WriteLine("\nLa Mascota :"+mascota.Nombre+" se adiciono  \n");
            _repoMascota.AddMascota(mascota);
         }
         private static void AddVeterinario()
        {
            var veterinario = new Veterinario{
                Nombre="Laura ",
                Apellidos= "gomez",

                
 
            };
            Console.WriteLine("\nEl Veterinario :"+veterinario.Nombre+" se adiciono  \n");
            _repoVeterinario.AddVeterinario(veterinario);
         }
               
        
        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            if (mascota != null)
            {
            string datos_Mascota = "\nNombre:"+mascota.Nombre +"\nvive en :"+mascota.Ciudad;
            Console.WriteLine(datos_Mascota);
            return;
            } 
            else
            {
                Console.WriteLine("No exite la mascota "+ idMascota); 
            }
             
        }
        private static void DeleteMascota(int idMascota)
        {
            _repoMascota.DeleteMascota(idMascota);
            Console.WriteLine("Mascota: "+idMascota+"Borrada");
        }
        
        
    }

}

// See https://aka.ms/new-console-template for more information

