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
            List<Pokemon> pokemones = new List<Pokemon>();
            List<PokemonDTO> pokemonesDTO = entrenador.PokemonesAtrapados();

            for (int i = 0; i < pokemonesDTO.Count; i++)
            {
                Pokemon pokemon = new Pokemon(pokemonesDTO[i].Id(), pokemonesDTO[i].Nombre(), pokemonesDTO[i].Orden(), pokemonesDTO[i].Tipo(), pokemonesDTO[i].Evolucion(), pokemonesDTO[i].Habilidad());
                pokemones.Add(pokemon);
            }

            repositorio.Registrar(new Entrenador(entrenador.Id(), entrenador.Nombre(), entrenador.Origen(), entrenador.Lider(), entrenador.Medallas(), pokemones));
        }
    }
}
