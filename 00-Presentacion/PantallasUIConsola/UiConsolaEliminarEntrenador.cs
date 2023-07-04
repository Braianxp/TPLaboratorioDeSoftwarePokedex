using _01_Aplicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion.PantallasUIConsola
{
    public class UiConsolaEliminarEntrenador
    {
        public void Ejecutar(EliminarEntrenador eliminarEntrenador)
        {
            Console.Clear();
            String cadena =
            "Eliminar Entrenador\n" +
            "...............................................................................................\n\n";

            Console.WriteLine(cadena);
            Console.WriteLine("Ingrese un Nombre de Entrenador para eliminar: ");
            String entrada = Console.ReadLine();
            eliminarEntrenador.Ejecutar(entrada);

            Console.WriteLine("Entrenador con Nombre " + entrada + " fue eliminado, presione cualquier boton para continuar...");
            Console.ReadLine();
        }
    }
}
