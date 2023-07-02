using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Infraestructura
{
    public class EntrenadorRepositorioEnMemoria : EntrenadorRepositorio
    {
        private List<Entrenador> entrenadores = new List<Entrenador>();

        public List<Entrenador> ObtenerEntrenadores()
        {
            return entrenadores;
        }

        public void Registrar(Entrenador entrenador)
        {
            this.entrenadores.Add(entrenador);
        }

        public Entrenador ObtenerEntrenadoresNombre(int nombre)
        {
            Entrenador entrenador = null;

            for (int i = 0; i < entrenadores.Count; i++)
            {
                if (nombre.Equals(entrenadores[i].Nombre()))
                {
                    entrenador = entrenadores[i];
                }

            }
            if (entrenador == null)
            {
                throw new Exception("El pokemon no existe");
            }

            return entrenador;
        }

        public void ModificarEntrenador(Entrenador entrenador)
        {
            for (int i = 0; i < entrenadores.Count; i++)
            {
                if (entrenador.Nombre().Equals(entrenadores[i].Nombre()))
                {
                    entrenadores[i] = entrenador;
                }

            }
            if (entrenador == null)
            {
                throw new Exception("El entrenador no existe");
            }

        }

        public void EliminarEntrenador(int nombre)
        {
            bool eliminado = false;

            for (int i = 0; i < entrenadores.Count; i++)
            {
                if (nombre.Equals(entrenadores[i].Nombre()))
                {
                    entrenadores.RemoveAt(i);
                    eliminado = true;
                }

            }
            if (!eliminado)
            {
                throw new Exception("El entrenador no se elimino");
            }
        }
    }
}
