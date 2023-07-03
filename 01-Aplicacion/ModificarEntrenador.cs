using _01_Aplicacion.DTO;
using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using _02_Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion
{
    public class ModificarEntrenador
    {
        private EntrenadorRepositorio repositorio;

        public ModificarEntrenador(EntrenadorRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }
        
        public void Ejecutar(EntrenadorDTO entrenador)
        {
            List<PokemonDTO> pokemonDTO = entrenador.PokemonesAtrapados();
            List<Pokemon> pokemones = new List<Pokemon>();
            for (int i = 0; i < pokemonDTO.Count; i++)
            {
                Pokemon pokemon = new Pokemon(pokemones[i].Id(), pokemones[i].Nombre(), pokemones[i].Orden(), pokemones[i].Tipo(), pokemones[i].Evolucion(), pokemones[i].Habilidad());
                pokemones.Add(pokemon);               
            }
            repositorio.ModificarEntrenador(new Entrenador(entrenador.Id(), entrenador.Nombre(), entrenador.Origen(), entrenador.Lider(), entrenador.Medallas(), pokemones));
        }
    }
 }

