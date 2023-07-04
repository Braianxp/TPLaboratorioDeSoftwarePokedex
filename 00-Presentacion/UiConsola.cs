using _00_Presentacion.PantallasUIConsola;
using _01_Aplicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion
{
    public class UiConsola : UI
    {
        private UiConsolaMenu uiConsolaMenu = new UiConsolaMenu();
        
        //pokemon
        private UiConsolaRegistrarPokemon uiConsolaRegistrarPokemon = new UiConsolaRegistrarPokemon();
        private UiConsolaBuscarPokemon uiConsolaBuscarPokemon = new UiConsolaBuscarPokemon();
        private UiConsolaObtenerPokemones uiConsolaObtenerPokemones = new UiConsolaObtenerPokemones();
        private UiConsolaEliminarPokemon uiConsolaEliminarPokemon = new UiConsolaEliminarPokemon();
        private UiConsolaModificarPokemon uiConsolaModificarPokemon = new UiConsolaModificarPokemon();
        
        //entrenador
        private UiConsolaRegistrarEntrenador uiConsolaRegistrarEntrenador = new UiConsolaRegistrarEntrenador();
        private UiConsolaBuscarEntrenador uiConsolaBuscarEntrenador = new UiConsolaBuscarEntrenador();
        private UiConsolaObtenerEntrenadores uiConsolaObtenerEntrenadores = new UiConsolaObtenerEntrenadores();
        private UiConsolaEliminarEntrenador uiConsolaEliminarEntrenador = new UiConsolaEliminarEntrenador();
        private UiConsolaModificarEntrenador uiConsolaModificarEntrenador = new UiConsolaModificarEntrenador();
        

        public char Menu()
        {
            return uiConsolaMenu.Ejecutar();
        }

        //Pokemon
        public void RegistrarPokemon(CrearPokemon crearPokemon)
        {
            uiConsolaRegistrarPokemon.Ejecutar(crearPokemon);
        }
        public void BuscarPokemon(BuscarPokemon buscarPokemon)
        {
            uiConsolaBuscarPokemon.Ejecutar(buscarPokemon);
        }

        public void ObtenerPokemones(ObtenerPokemones obtenerPokemones)
        {
            uiConsolaObtenerPokemones.Ejecutar(obtenerPokemones);
        }

        public void ModificarPokemon(ModificarPokemon modificarPokemon, BuscarPokemon buscarPokemon)
        {
            uiConsolaModificarPokemon.Ejecutar(modificarPokemon,buscarPokemon);
        }

        public void EliminarPokemon(EliminarPokemon eliminarPokemon)
        {
            uiConsolaEliminarPokemon.Ejecutar(eliminarPokemon);
        }

        //Entrenador
        public void RegistrarEntrenador(CrearEntrenador crearEntrenador, ObtenerPokemones obtenerPokemones)
        {
            uiConsolaRegistrarEntrenador.Ejecutar(crearEntrenador, obtenerPokemones);
        }
        public void EliminarEntrenador(EliminarEntrenador eliminarEntrenador)
        {
            uiConsolaEliminarEntrenador.Ejecutar(eliminarEntrenador);
        }
        public void ModificarEntrenador(ModificarEntrenador modificarEntrenador,BuscarEntrenador buscarEntrenador, ObtenerPokemones obtenerPokemones)
        {
            uiConsolaModificarEntrenador.Ejecutar(modificarEntrenador,buscarEntrenador, obtenerPokemones);
        }  
        public void ObtenerEntrenadores(ObtenerEntrenadores obtenerEntrenadores)
        {
            uiConsolaObtenerEntrenadores.Ejecutar(obtenerEntrenadores);
        }
        public void BuscarEntrenador(BuscarEntrenador buscarEntrenador)
        {
            uiConsolaBuscarEntrenador.Ejecutar(buscarEntrenador);
        }
    }
}
