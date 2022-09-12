using PetCare.App.Dominio;
using PetCare.App.Persistencia;

namespace PetCare.App.Consola
{
    class program
    {
        private static IRepositorioPropietario _repoPropietario= new RepositorioPropietario(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World Entity framework! ");
            //AddPropietario();
            BuscarPropietario(1);
        }

        private static void AddPropietario()
        {
            var propietario = new Propietario{
                Direccion = "carrera47#51-49",
                Edad = "22"
            };
            _repoPropietario.AddPropietario(Propietario);
        }
        private static void BuscarPropietario(ind idMascota)
        {
            var propietario = _repoPropietario.GetPropietario(idMascota);
            console.WriteLine(propietario.Direccion_+""+propietario.Edad);
        }

    }
}


// See https://aka.ms/new-console-template for more information

