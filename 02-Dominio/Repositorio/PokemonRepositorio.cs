﻿using _02_Dominio.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.Repositorio
{
    public interface PokemonRepositorio
    {
        public void Registrar(Pokemon pokemon);

        public List<Pokemon> ObtenerPokemones();

        public Pokemon ObtenerPokemonesOrden(int orden);

        public void Modificar(Pokemon pokemon);

        public void EliminarPokemon(int orden);
        
    }
}