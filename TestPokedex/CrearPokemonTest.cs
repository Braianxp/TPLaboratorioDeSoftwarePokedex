using _01_Aplicacion.DTO;
using _01_Aplicacion;
using _03_Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TPLaboratorioDeSoftwarePokedexTest
{
    public class CrearPokemonTest
    {
        [Fact]
        public void CrearPokemon_CreadoCorrectamente()
        {
            //Arrange
            PokemonRepositorioEnMemoria pokemonRepositorioEnMemoria = new PokemonRepositorioEnMemoria();
            CrearPokemon crearPokemon = new CrearPokemon(pokemonRepositorioEnMemoria);
            PokemonDTO pokemonDTO = new PokemonDTO(Guid.NewGuid(), "Newtwo", 0150, "Psiquico", "New", "Rayo");

            //ACT
            crearPokemon.ejecutar(pokemonDTO);

            //Assert
            Assert.NotEmpty(pokemonRepositorioEnMemoria.ObtenerPokemones());
        }
    }
}
