using PetCare.App.Dominio;
using PetCare.App.Persistencia;
using System;

namespace PetCare.App.Consola
{
    class program
    {
        private static IRepositorioVeterinario _repoVeterinario= new RepositorioVeterinario(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World Entity framework! ");
            // AddVeterinario();
            // BuscarVeterinario(1);
            // DeleteVeterinario(2);
            // UpdateVeterinario(1);
            GetAllVeterinarios();
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario{
                Nombre="michael",
                Apellidos="Bulldog",
                NumeroTelefono="",
                Genero= Genero.Masculino,
                Correo="",
                TarjetaProfesional="1343534124",
                Especialidad="general"
 
            };
            Console.WriteLine("\nel veterinario: "+veterinario.Nombre+" se adiciono  \n");
            _repoVeterinario.AddVeterinario(veterinario);
            
        }
        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            string datos_veterinario = "\nNombre: "+veterinario.Nombre+"\nApellidos: "+veterinario.Apellidos+"\nNumero de Telefono: "+veterinario.NumeroTelefono+"\nGenero: "+veterinario.Genero;
            Console.WriteLine(datos_veterinario);      
        }
        private static void DeleteVeterinario(int idVeterinario)
        {        
            string nombreVeterinario = _repoVeterinario.GetVeterinario(idVeterinario).Nombre;
            Console.WriteLine("Borrando veterinario "+ nombreVeterinario +"...\n");     
            _repoVeterinario.DeleteVeterinario(idVeterinario); 
            Console.WriteLine("Veterinario "+ nombreVeterinario+ " borrado!");                  
        } 
        private static void UpdateVeterinario(int idVeterinario_original)
        {            
            var veterinario_actualizado = new Veterinario
            {
                
                //Nombre = "Nicolay",
                //Apellidos = "Perez",
                //Nombre = "Nicolay2",
                //Apellidos = "Perez2",
                Nombre = "Pedro",
                Apellidos = "Rodriguez",                
                NumeroTelefono = "3001645",
                Genero = Genero.Masculino,
                TarjetaProfesional="848362837498",
                Especialidad="Cirujano"
            };
            _repoVeterinario.UpdateVeterinario(veterinario_actualizado, idVeterinario_original);
            //var veterinario = _repoVeterinario.UpdateVeterinario(idVeterinario);

            Console.WriteLine("Veterinario "+ veterinario_actualizado.Nombre+" actualizado!");
            //return veterinario_actualizado;           
                
        }
        private static void GetAllVeterinarios()
        {
          var veterinarios = _repoVeterinario.GetAllVeterinarios();          
          Console.WriteLine("Lista de veterinarios:\n");    
          foreach(var veterinario in veterinarios){
            Console.WriteLine(veterinario.Id + " - " + veterinario.Nombre);
          }
        }    
    }
}

// See https://aka.ms/new-console-template for more information