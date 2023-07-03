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
    public class BuscarEntrenador
    {
        EntrenadorRepositorio repositorio;

        public BuscarEntrenador(EntrenadorRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public EntrenadorDTO Ejecutar(string nombre)
        {

            EntrenadorDTO entrenadorDTO = null;
            Entrenador entrenador1 = repositorio.ObtenerEntrenadoresNombre(nombre);

            List<Pokemon> pokemones = entrenador1.PokemonesAtrapados();
            List<PokemonDTO> pokemonesDTO = new List<PokemonDTO>();
            for (int i = 0; i < pokemones.Count; i++)
            {
                PokemonDTO pokemonDTO = new PokemonDTO(pokemones[i].Id(), pokemones[i].Nombre(), pokemones[i].Orden(), pokemones[i].Tipo(), pokemones[i].Evolucion(), pokemones[i].Habilidad());
                pokemonesDTO.Add(pokemonDTO);
            }
            
            entrenadorDTO = new EntrenadorDTO(entrenador1.Id(), entrenador1.Nombre(), entrenador1.Origen(), entrenador1.Lider(), entrenador1.Medallas(), pokemonesDTO);
            return entrenadorDTO;
        }
    }
}