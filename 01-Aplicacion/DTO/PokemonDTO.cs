using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion.DTO
{
    public class PokemonDTO
    {
        private Guid id;
        private String nombre;
        private int orden;
        private String tipo;
        private String evolucion;
        private String habilidad;

        public PokemonDTO(Guid id, String nombre, int orden, String tipo, String evolucion, String habilidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.orden = orden;
            this.tipo = tipo;
            this.evolucion = evolucion;
            this.habilidad = habilidad;
        }

        public Guid Id()
        {
            return this.id;
        }

        public String Nombre()
        {
            return this.nombre;
        }

        public int Orden()
        {
            return this.orden;
        }

        public String Tipo()
        {
            return this.tipo;
        }

        public String Evolucion()
        {
            return this.evolucion;
        }

        public String Habilidad()
        {
            return this.habilidad;
        }

    }
}