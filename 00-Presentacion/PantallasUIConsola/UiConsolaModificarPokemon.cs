using _01_Aplicacion;
using _01_Aplicacion.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion.PantallasUIConsola
{
    public class UiConsolaModificarPokemon
    {
        private static String[] atributosPokemon = { "Nombre", "Tipo", "Evolucion", "Habilidad" };
        public void Ejecutar(ModificarPokemon modificarPokemon, BuscarPokemon buscarPokemon) {

            Console.Clear();
            String cadena =
            "Modificar Pokemon\n" +
            "...............................................................................................\n\n";

            Console.WriteLine(cadena);

            Console.Write("Ingrese el N° Orden de Pokemon para Modificar:  ");
            String entradaOrden = Console.ReadLine();
            int orden = Int32.Parse(entradaOrden);

            PokemonDTO pokemonDTO = buscarPokemon.Ejecutar(orden);

            String[] informacionPokemon = new String[atributosPokemon.Length];

            for (int i = 0; i < atributosPokemon.Length; i++)
            {
                String entradaAtributos = null;
                do
                {
                    Console.Write("Ingrese un valor para " + atributosPokemon[i] + ": ");
                    entradaAtributos = Console.ReadLine();

                    if (entradaAtributos.Length >= 1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ADVERTENCIA! Debe ingresar algun valor para continuar.");
                    }
                } while (true);

                informacionPokemon[i] = entradaAtributos;
            }

            PokemonDTO pokemonDTOModificado = new PokemonDTO(pokemonDTO.Id(),
            informacionPokemon[0],
            orden,
            informacionPokemon[1],
            informacionPokemon[2],
            informacionPokemon[3]);

            modificarPokemon.Ejecutar(pokemonDTOModificado);

            Console.WriteLine("Pokemon modificado, presione cualquier boton para continuar...");
            Console.ReadLine();
        }
    }
}
