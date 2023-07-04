using _01_Aplicacion;
using _01_Aplicacion.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion.PantallasUIConsola
{
    public class UiConsolaModificarEntrenador
    {
        private static String[] atributosEntrenador = { "Origen", "LiderDeGimnasio (Si o No)", "Medallas" };
        public void Ejecutar(ModificarEntrenador modificarEntrenador, BuscarEntrenador buscarEntrenador, ObtenerPokemones obtenerPokemones)
        {
            Console.Clear();
            String cadena =
            "Modificar Entrenador\n" +
            "...............................................................................................\n";

            Console.WriteLine(cadena);

            Console.WriteLine("Ingrese un Nombre de Entrenador para Modificar: ");
            String entradaNombre = Console.ReadLine();

            EntrenadorDTO entrenadorDTO = buscarEntrenador.Ejecutar(entradaNombre);

            String[] informacionEntrenador = new String[atributosEntrenador.Length];

            for (int i = 0; i < atributosEntrenador.Length; i++)
            {
                String entradaAtributos;
                do
                {
                    Console.Write("Ingrese un valor para " + atributosEntrenador[i] + ": ");
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

                informacionEntrenador[i] = entradaAtributos;
            }

            List<PokemonDTO> pokemonesDTO = obtenerPokemones.Ejecutar();

            Console.WriteLine("-------------------Lista de Pokemones para asignar-------------------");
            foreach (var pokemonDTO in pokemonesDTO)
            {
                Console.WriteLine(pokemonDTO.Describirse());
            }

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("\nEscriba los N° de Orden de Pokemon para asignarlos al Entrenador separados por , ");

            string cadenaListaPokemones = Console.ReadLine();


            String[] ordenPokemones = cadenaListaPokemones.Split(",");

            List<PokemonDTO> pokemonesDTOEntrenador = new List<PokemonDTO>();

            foreach (var stringOrden in ordenPokemones)
            {
                int orden = int.Parse(stringOrden);
                foreach (var pokemonDTO in pokemonesDTO)
                {
                    if (pokemonDTO.Orden() == orden)
                    {
                        pokemonesDTOEntrenador.Add(pokemonDTO);
                        break;
                    }
                }
            }

            bool liderDeGimnasio = false;
            if (informacionEntrenador[2].Equals("Si") || informacionEntrenador[2].Equals("Si"))
            {
                liderDeGimnasio = true;
            }

            EntrenadorDTO entrenadorDTOModificado = new EntrenadorDTO(entrenadorDTO.Id(),
            entradaNombre,
            informacionEntrenador[0],
            liderDeGimnasio,
            Int32.Parse(informacionEntrenador[2]),
            pokemonesDTOEntrenador);

            modificarEntrenador.Ejecutar(entrenadorDTOModificado);

            Console.WriteLine("Entrenador modificado, presione cualquier boton para continuar...");
            Console.ReadLine();
        }
    }
}
