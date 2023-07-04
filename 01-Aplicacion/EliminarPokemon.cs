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
    public class EliminarPokemon
    {
        private PokemonRepositorio repositorio;

        public EliminarPokemon(PokemonRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Ejecutar(int orden)
        {
           repositorio.EliminarPokemon(orden);
            
        }
    }
}
