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

        public void Ejecutar (PokemonDTO pokemonDTO)
        {
            repositorio.Modificar(new Pokemon(pokemonDTO.Id(), pokemonDTO.Nombre(), pokemonDTO.Orden(), pokemonDTO.Tipo(), pokemonDTO.Evolucion(), pokemonDTO.Habilidad()));

        }

    }
}