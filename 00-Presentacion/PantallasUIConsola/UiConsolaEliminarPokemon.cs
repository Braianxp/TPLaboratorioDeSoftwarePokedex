using _01_Aplicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion.PantallasUIConsola
{
    public class UiConsolaEliminarPokemon
    {
        public void Ejecutar(EliminarPokemon eliminarPokemon)
        {
            Console.Clear();
            String cadena =
            "Eliminar Pokemon\n" +
            "...............................................................................................\n\n";

            Console.WriteLine(cadena);
            Console.WriteLine("Ingrese un N° de Orden de Pokemon para eliminar: ");
            String entrada = Console.ReadLine();
            int orden = Int32.Parse(entrada);
            eliminarPokemon.Ejecutar(orden);

            Console.WriteLine("Pokemon con N° Orden " + orden + " eliminado, presione cualquier boton para continuar...");
            Console.ReadLine();
        }
    }
}
