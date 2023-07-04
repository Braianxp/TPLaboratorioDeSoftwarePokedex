using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.ValueObject
{
    public class Medallas
    {
        int valor;

        public Medallas(int valor)
        {
            this.valor = valor;
        }

        public int Valor()
        {
            return this.valor;
        }
    }
}
