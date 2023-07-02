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
    public class ObtenerEntrenador
    {
        EntrenadorRepositorio repositorio;

        public ObtenerEntrenador(EntrenadorRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<EntrenadorDTO> Ejecutar()
        {
            List<Entrenador> entrenadores = this.repositorio.ObtenerEntrenadores();
            List<EntrenadorDTO> entrenadoresDTO = new List<EntrenadorDTO>();
            foreach (Entrenador entrenador in entrenadores)
            {
                EntrenadorDTO entrenadorDTO= new EntrenadorDTO(entrenador.Id(), entrenador.Nombre(), entrenador.Origen(), entrenador.Lider(), entrenador.Medallas(), entrenador.PokemonesAtrapados());
                entrenadoresDTO.Add(entrenadorDTO);
            }
            return entrenadoresDTO;
        }
    }
}
}
