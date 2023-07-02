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
    public class CrearEntrenador
    {
        private EntrenadorRepositorio repositorio;

        public CrearEntrenador(EntrenadorRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void ejecutar(EntrenadorDTO entrenador)
        {
            repositorio.Registrar(new Entrenador(entrenador.Id(), entrenador.Nombre(), entrenador.Origen(), entrenador.Lider(), entrenador.Medallas(), entrenador.PokemonesAtrapados()));
        }
    }
}
