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
        private List<Pokemon> pokemones = new List<Pokemon>() { new Pokemon(Guid.NewGuid(), "Newtwo", 150, "Psiquico", "New", "Ataqeu psiquico")};

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
            Pokemon pokemon = null;

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
