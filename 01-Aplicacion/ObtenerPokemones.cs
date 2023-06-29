using _01_Aplicacion.DTO;
using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion
{
    public class ObtenerPokemones
    {
        PokemonRepositorio repositorio;

        public ObtenerPokemones(PokemonRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<PokemonDTO> Ejecutar()
        {
            List<Pokemon> pokemones = this.repositorio.ObtenerPokemones();
            List<PokemonDTO> pokemonesDTO = new List<PokemonDTO>();
            foreach ( Pokemon pokemon in pokemones)
            {
                PokemonDTO pokemonDTO = new PokemonDTO(pokemon.Id(),pokemon.Nombre(),pokemon.Orden(),pokemon.Tipo(),pokemon.Evolucion(),pokemon.Habilidad());
                pokemonesDTO.Add(pokemonDTO);
            }
            return pokemonesDTO;
        }
    }
}
