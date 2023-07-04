using _01_Aplicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion
{
    public interface UI
    {
        public char Menu();

        //pokemon
        public void RegistrarPokemon(CrearPokemon creadorDePokemons);
        public void BuscarPokemon(BuscarPokemon buscarPokemon);
        public void ObtenerPokemones(ObtenerPokemones buscarPokemon);
        public void EliminarPokemon(EliminarPokemon eliminarpokemon);
        public void ModificarPokemon(ModificarPokemon modificarPokemon, BuscarPokemon buscarPokemon);
        
        //entrenador
        public void RegistrarEntrenador(CrearEntrenador crearEntrenador, ObtenerPokemones obtenerPokemones);
        public void BuscarEntrenador(BuscarEntrenador buscarEntrenador);
        public void ObtenerEntrenadores(ObtenerEntrenadores obtenerEntrenadores);
        public void EliminarEntrenador(EliminarEntrenador eliminarEntrenador);
        public void ModificarEntrenador(ModificarEntrenador modificarEntrenador, BuscarEntrenador buscarEntrenador, ObtenerPokemones obtenerPokemones);

    }
}
