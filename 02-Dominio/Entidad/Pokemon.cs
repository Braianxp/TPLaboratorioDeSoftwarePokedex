using _02_Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.Entidad
{
    public class Pokemon
    {
        private Identificador id;
        private Nombre nombre;
        private Orden orden;
        private Tipo tipo;
        private Evolucion evolucion;
        private Habilidad habilidad;

        public Pokemon(Guid id, String nombre, int orden, String tipo, String evolucion, String habilidad)
        {
            this.id = new Identificador(id);
            this.nombre = new Nombre(nombre);
            this.orden = new Orden(orden);
            this.tipo = new Tipo(tipo);
            this.evolucion = new Evolucion(evolucion);
            this.habilidad = new Habilidad(habilidad);
        }

        public Guid Id()
        {
            return this.id.Valor();
        }

        public String Nombre()
        {
            return this.nombre.Valor();
        }

        public int Orden()
        {
            return this.orden.Valor();
        }

        public String Tipo()
        {
            return tipo.Valor();
        }

        public String Evolucion()
        {
            return evolucion.Valor();
        }

        public String Habilidad()
        {
            return habilidad.Valor();
        }
    }
}
