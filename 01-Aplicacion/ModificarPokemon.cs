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
    public class ModificarPokemon
    {
        private PokemonRepositorio repositorio;

        public ModificarPokemon(PokemonRepositorio repositorio)
        {
           this.repositorio = repositorio;
        }

        public void ModificadorDePokemones(PokemonDTO pokemonDTO)
        {
            Pokemon pokemon = repositorio.ObtenerPokemones(pokemonDTO.Id);

            if (pokemon != null)
            {
                pokemon.Nombre = pokemonDTO.Nombre;
                pokemon.Orden = pokemonDTO.Orden;
                pokemon.Tipo = pokemon.Tipo;
                pokemon.Evolucion = pokemonDTO.Evolucion;
                pokemon.Habilidad = pokemonDTO.Habilidad;

                repositorio.Actualizar(pokemon);
            }
            else
            {
                throw new Exception("El pokemon no existe");
            }
         
        }       

    }
}