using _00_Presentacion.PantallasUIAscii;
using _01_Aplicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion
{
    public class UiAscii : UI
    {
        private UiAsciiMenu uiAsciiMenu = new UiAsciiMenu();
        private UiAsciiRegistrarPokemon uiAsciiRegistrarPokemon = new UiAsciiRegistrarPokemon();
        public char Menu()
        {
            return this.uiAsciiMenu.Ejecutar();
        }

        public void RegistrarPokemon()
        {
            this.uiAsciiRegistrarPokemon.Ejecutar();
        }

        public void AsignarPokemon()
        {
            throw new NotImplementedException();
        }

        public void BuscarEntrenador()
        {
            throw new NotImplementedException();
        }

        public void BuscarPokemon()
        {
            throw new NotImplementedException();
        }

        public void EliminarEntrenador()
        {
            throw new NotImplementedException();
        }

        public void EliminarPokemon()
        {
            throw new NotImplementedException();
        }

        public void RegistrarEntrenador()
        {
            throw new NotImplementedException();
        }

        public void TodosLosEntrenadores()
        {
            throw new NotImplementedException();
        }

        public void TodosLosPokemones()
        {
            throw new NotImplementedException();
        }
    }
}
