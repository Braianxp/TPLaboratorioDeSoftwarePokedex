using _01_Aplicacion;
using _01_Aplicacion.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion.PantallasUIConsola
{
    public class UiConsolaObtenerEntrenadores
    {
        public void Ejecutar(ObtenerEntrenadores obtenerEntrenadores)
        {
            Console.Clear();
            String cadena =
            "Obtener Entrenadores\n" +
            "...............................................................................................\n";

            Console.WriteLine(cadena);

            List<EntrenadorDTO> entrenadoresDTO = obtenerEntrenadores.Ejecutar();

            foreach (var entrenadorDTO in entrenadoresDTO)
            {
                Console.WriteLine(entrenadorDTO.Describirse());
            }

            Console.WriteLine("\npresione cualquier boton para continuar...");
            Console.ReadLine();
        }
    
    }
}
