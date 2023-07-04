using _01_Aplicacion;
using _01_Aplicacion.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion.PantallasUIConsola
{
    public class UiConsolaRegistrarPokemon
    {
        private static String[] atributosPokemon = { "Nombre", "N°", "Tipo", "Evolucion", "Habilidad" };

        public void Ejecutar(CrearPokemon crearPokemon)
        {
            Console.Clear();
            String cadena =
            "Regisrar Pokemon\n" +
            "...............................................................................................\n\n";

            Console.WriteLine(cadena);


            String[] informacionPokemon = new String[atributosPokemon.Length];
             
             for(int i = 0; i < atributosPokemon.Length; i++)
             {
                String entrada;
                do
                {
                    Console.Write("Ingrese un valor para " + atributosPokemon[i] + ": ");
                    entrada = Console.ReadLine();

                    if (entrada.Length >= 1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ADVERTENCIA! Debe ingresar algun valor para continuar.");
                    }
                } while (true);

                informacionPokemon[i] = entrada;
             }

            PokemonDTO pokemonDTO = new PokemonDTO(Guid.NewGuid(),
            informacionPokemon[0],
            Int32.Parse(informacionPokemon[1]),
            informacionPokemon[2],
            informacionPokemon[3],
            informacionPokemon[4]);

            crearPokemon.ejecutar(pokemonDTO);

            Console.WriteLine("Pokemon registrado presione cualquier boton para continuar...");
            Console.ReadLine();
        }


    }
}
