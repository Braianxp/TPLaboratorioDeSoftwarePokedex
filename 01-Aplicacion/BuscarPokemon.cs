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
    public class BuscarPokemon
    {
        PokemonRepositorio repositorio;

        public BuscarPokemon(PokemonRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public PokemonDTO Ejecutar(int orden)
        {
            Pokemon pokemon = repositorio.ObtenerPokemonesOrden(orden);
            PokemonDTO pokemonDTO = new PokemonDTO(pokemon.Id(), pokemon.Nombre(), pokemon.Orden(), pokemon.Tipo(), pokemon.Evolucion(), pokemon.Habilidad());
            return pokemonDTO;
        }
    }
}
