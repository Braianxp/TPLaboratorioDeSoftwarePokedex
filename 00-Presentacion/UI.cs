using Microsoft.Win32;
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
        public void RegistrarPokemon();
        public void BuscarPokemon();
        public void TodosLosPokemones();
        public void EliminarPokemon();
        public void RegistrarEntrenador();
        public void BuscarEntrenador();
        public void TodosLosEntrenadores();
        public void EliminarEntrenador();
        public void AsignarPokemon();

    }
}
