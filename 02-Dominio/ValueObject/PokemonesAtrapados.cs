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
        List<Pokemon> valor;

        public PokemonesAtrapados(List<Pokemon> valor)
        {
            this.valor = valor;
        }

        public List<Pokemon> Valor()
        {
            return this.valor;
        }
    }
}
