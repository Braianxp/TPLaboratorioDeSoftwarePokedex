using _02_Dominio.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.ValueObject
{
    public class PokemonesAtrapados
    {
        List<PokemonesAtrapados> valor;

        public PokemonesAtrapados(List<PokemonesAtrapados> valor)
        {
            this.valor = valor;
        }

        public List<PokemonesAtrapados> Valor()
        {
            return this.valor;
        }
    }
}
