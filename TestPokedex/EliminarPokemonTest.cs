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
    public class EliminarPokemonTest
    {
        [Fact]
        public void EliminarPokemon_EliminadoCorrectamente()
        {
            // Arrange
            PokemonRepositorioEnMemoria pokemonRepositorioEnMemoria = new PokemonRepositorioEnMemoria();
            EliminarPokemon eliminarPokemon = new EliminarPokemon(pokemonRepositorioEnMemoria);
            var orden = 150;

            // Act
            eliminarPokemon.Ejecutar(orden); //Elimina el pokemon

            // Assert
            Assert.Empty(pokemonRepositorioEnMemoria.ObtenerPokemones()); // Verifica que la lista quedo vacia
        }

        [Fact]
        public void EliminarPokemon_PokemonNoEliminado_LanzaExcepcion()
        {
            // Arrange
            PokemonRepositorioEnMemoria pokemonRepositorioEnMemoria = new PokemonRepositorioEnMemoria();
            EliminarPokemon eliminarPokemon = new EliminarPokemon(pokemonRepositorioEnMemoria);
            var orden = 150;

            // Act y Assert
            var exception = Assert.Throws<Exception>(() => eliminarPokemon.Ejecutar(0001));
            Assert.Equal("El pokemon no se elimino", exception.Message); // Verifica que se lance la excepción esperada con el mensaje correcto
        }
    }
}
