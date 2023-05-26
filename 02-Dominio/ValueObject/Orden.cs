using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.ValueObject
{
    public class Orden
    {
        int valor;
        public Orden(int valor)
        {
            this.valor = valor;
        }

        public int Valor()
        {
            return this.valor;
        }
    }
}
