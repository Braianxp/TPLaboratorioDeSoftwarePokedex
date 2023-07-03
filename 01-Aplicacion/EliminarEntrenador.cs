using _02_Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion
{
    public class EliminarEntrenador
    {
        private EntrenadorRepositorio repositorio;

        public EliminarEntrenador(EntrenadorRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Ejecutar(string nombre)
        {
            repositorio.EliminarEntrenador(nombre);

        }
    }
}
