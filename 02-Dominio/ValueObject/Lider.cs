using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.ValueObject
{
    public class Lider
    {
        bool valor;

        public Lider(bool valor)
        {
            this.valor = valor;
        }

        public bool Valor()
        {
            return this.valor;
        }
    }
}
