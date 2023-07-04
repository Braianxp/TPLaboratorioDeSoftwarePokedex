using _01_Aplicacion;
using _01_Aplicacion.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion.PantallasUIConsola
{
    public class UiConsolaBuscarEntrenador
    {
        public void Ejecutar(BuscarEntrenador buscarEntrenador)
        {
            Console.Clear();
            String cadena =
            "Buscar Entrenador\n" +
            "...............................................................................................\n";

            Console.WriteLine(cadena);

            Console.WriteLine("Ingrese un Nmbre de Entrenador para buscar: ");
            String entrada = Console.ReadLine();

            EntrenadorDTO entrenadorDTO = buscarEntrenador.Ejecutar(entrada);

            if (entrenadorDTO == null)
            {
                Console.WriteLine("No existe ningun Entrenador con el Nombre");
            }
            else
            {
                Console.WriteLine(entrenadorDTO.Describirse());
            }

            Console.WriteLine("\nPresione cualquier boton para continuar...");
            Console.ReadLine();
        }
    }
}
