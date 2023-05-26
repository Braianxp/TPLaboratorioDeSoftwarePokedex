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
    public class CrearPokemon
    {
        private PokemonRepositorio repositorio;

        public CrearPokemon(PokemonRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void ejecutar(PokemonDTO pokemon)
        {
            repositorio.Registrar(new Pokemon(pokemon.Id(), pokemon.Nombre(), pokemon.Orden(), pokemon.Tipo(), pokemon.Evolucion(), pokemon.Habilidad()));
        }
    }
}
