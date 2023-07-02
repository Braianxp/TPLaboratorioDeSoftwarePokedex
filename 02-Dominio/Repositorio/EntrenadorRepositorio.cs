using _02_Dominio.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.Repositorio
{
    public interface EntrenadorRepositorio
    {
        public void Registrar(Entrenador entrenador);

        public List<Entrenador> ObtenerEntrenadores();

        public Entrenador ObtenerEntrenadoresNombre(int nomnbre);

        public void ModificarEntrenador(Entrenador entrenador);

        public void EliminarEntrenador(int nombre);
    }
}
