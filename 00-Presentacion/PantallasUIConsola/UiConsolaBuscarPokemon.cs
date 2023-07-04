using _01_Aplicacion;
using _01_Aplicacion.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion.PantallasUIConsola
{
    public class UiConsolaBuscarPokemon
    {
        public void Ejecutar(BuscarPokemon buscarPokemon)
        {
            Console.Clear();
            String cadena =
            "Buscar Pokemon\n" +
            "...............................................................................................\n\n";

            Console.WriteLine(cadena);

            Console.WriteLine("Ingrese un N° de Orden de Pokemon para buscar: ");
            String entrada = Console.ReadLine();
            int orden = Int32.Parse(entrada);

            PokemonDTO pokemonDTO = buscarPokemon.Ejecutar(orden);

            if (pokemonDTO == null)
            {
                Console.WriteLine("No existe ningun pokemon con ese N° de orden");
            }
            else
            {
                Console.WriteLine(pokemonDTO.Describirse());
            }

            Console.WriteLine("Presione cualquier boton para continuar...");
            Console.ReadLine();
        }
    
    }
}
