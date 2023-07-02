using _02_Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.Entidad
{
    public class Entrenador
    {
        private Identificador id;
        private Nombre nombre;
        private Origen origen;
        private Lider liderDeGimnasio;
        private Medallas medallas;
        private PokemonesAtrapados pokemonesAtrapados;

        public Entrenador(Guid id, string nombre, string origen, bool liderDeGimnasio, int medallas, List<PokemonesAtrapados> pokemonesAtrapados)
        {
            this.id = new Identificador(id);
            this.nombre = new Nombre(nombre);
            this.origen = new Origen(origen);
            this.liderDeGimnasio = new Lider(liderDeGimnasio);
            this.medallas = new Medallas(medallas);
            this.pokemonesAtrapados = new PokemonesAtrapados(pokemonesAtrapados);
        }

        public Guid Id()
        {
            return id.Valor();
        }

        public string Nombre()
        {
            return nombre.Valor();
        }

        public string Origen()
        {
            return origen.Valor();
        }

        public bool Lider()
        {
            return liderDeGimnasio.Valor();
        }

        public int Medallas()
        {
            return medallas.Valor();
        }

        public List<PokemonesAtrapados> PokemonesAtrapados()
        {
            return pokemonesAtrapados.Valor();
        }
    }
}
