using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
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
        public void Registrar(Pokemon pokemon)
        {
            this.pokemones.Add(pokemon);
        }
    }
}
