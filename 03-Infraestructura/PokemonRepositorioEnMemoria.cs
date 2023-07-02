using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using _02_Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Infraestructura
{
    public class PokemonRepositorioEnMemoria : PokemonRepositorio
    {
        private List<Pokemon> pokemones = new List<Pokemon>();

        public List<Pokemon> ObtenerPokemones()
        {
            return pokemones;
        }

        public void Registrar(Pokemon pokemon)
        {
            this.pokemones.Add(pokemon);
        }

        public Pokemon ObtenerPokemonesOrden(int orden)
        {
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            Pokemon pokemon = null;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

            for (int i = 0; i < pokemones.Count; i++)
            {
                if (orden == pokemones[i].Orden())
                {
                    pokemon = pokemones[i];
                }

            }
            if (pokemon == null)
            {
                throw new Exception("El pokemon no existe");
            }

            return pokemon;
        }

        public void Modificar(Pokemon pokemon)
        {
            for (int i = 0; i < pokemones.Count; i++)
            {
                if (pokemon.Id() == pokemones[i].Id())
                {
                    pokemones[i] = pokemon;
                }

            }
            if (pokemon == null)
            {
                throw new Exception("El pokemon no existe");
            }

        }

        public void EliminarPokemon(int orden)
        {
            bool eliminado = false;
            
            for (int i = 0; i < pokemones.Count; i++)
            {
                if (orden == pokemones[i].Orden())
                {
                    pokemones.RemoveAt(i);
                    eliminado = true;
                }

            }
            if (!eliminado)
            {
                throw new Exception("El pokemon no se elimino");
            }
        }        
    }
}
