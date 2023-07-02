using _02_Dominio.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion.DTO
{
    public class EntrenadorDTO
    {
        private Guid id;
        private string nombre;
        private string origen;
        private bool liderDeGimnasio;
        private int medallas;
        private List<Pokemon> pokemonesAtrapados;

        public EntrenadorDTO(Guid id, string nombre, string origen, bool liderDeGimnasio, int medallas, List<Pokemon> pokemonsAtrapados)
        {
            this.id = id;
            this.nombre = nombre;
            this.origen = origen;
            this.liderDeGimnasio = liderDeGimnasio;
            this.medallas = medallas;
            this.pokemonesAtrapados = pokemonsAtrapados;
        }

        public Guid Id()
        {
            return this.id;
        }

        public String Nombre()
        {
            return this.nombre;
        }

        public string Origen()
        {
            return this.origen;
        }

        public bool Lider()
        {
            return this.liderDeGimnasio;
        }

        public List<Pokemon> PokemonesAtrapados()
        {
            return this.pokemonesAtrapados;
        }
    }
}
