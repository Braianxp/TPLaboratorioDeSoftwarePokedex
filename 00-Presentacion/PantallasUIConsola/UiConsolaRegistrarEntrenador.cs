using _01_Aplicacion.DTO;
using _01_Aplicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion.PantallasUIConsola
{
    public class UiConsolaRegistrarEntrenador
    {
        private static String[] atributosEntrenador = { "Nombre", "Origen", "LiderDeGimnasio (Si o No)", "Medallas"};
        public void Ejecutar(CrearEntrenador crearEntrenador, ObtenerPokemones obtenerPokemones)
        {
            Console.Clear();
            String cadena =
            "Regisrar Entrenador\n" +
            "...............................................................................................\n\n";

            Console.WriteLine(cadena);


            String[] informacionEntrenador = new String[atributosEntrenador.Length];

            for (int i = 0; i < atributosEntrenador.Length; i++)
            {
                String entrada;
                do
                {
                    Console.Write("Ingrese un valor para " + atributosEntrenador[i] + ": ");
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

                informacionEntrenador[i] = entrada;
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
                    if(pokemonDTO.Orden() == orden)
                    {
                        pokemonesDTOEntrenador.Add(pokemonDTO);
                        break;
                    }
                }
            }

            bool liderDeGimnasio = false;
            if(informacionEntrenador[2].Equals("Si") || informacionEntrenador[2].Equals("Si"))
            {
                liderDeGimnasio = true;
            }

            EntrenadorDTO EntrenadorDTO = new EntrenadorDTO(Guid.NewGuid(),
            informacionEntrenador[0],
            informacionEntrenador[1],
            liderDeGimnasio,
            Int32.Parse(informacionEntrenador[3]),
            pokemonesDTOEntrenador);

            crearEntrenador.ejecutar(EntrenadorDTO);

            Console.WriteLine("Entrenador registrado presione cualquier boton para continuar...");
            Console.ReadLine();
        }
        
    
    }
}
