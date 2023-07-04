using _01_Aplicacion;
using _01_Aplicacion.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion.PantallasUIConsola
{
    public class UiConsolaObtenerPokemones
    {
        public void Ejecutar(ObtenerPokemones obtenerPokemones)
        {
            Console.Clear();
            String cadena =
            "Obtener Pokemones\n" +
            "...............................................................................................\n";

            Console.WriteLine(cadena);

            List<PokemonDTO> listapokemonDTO = obtenerPokemones.Ejecutar();

            foreach (var pokemonDTO in listapokemonDTO)
            {
                Console.WriteLine(pokemonDTO.Describirse());
            }
            Console.WriteLine("\nPresione cualquier boton para continuar...");
            Console.ReadLine();
        }
    }
}
