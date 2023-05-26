using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.ValueObject
{
    public class Tipo
    {
        String valor;

        public Tipo(String valor)
        {
            this.valor = valor;
        }

        public String Valor()
        {
            return this.valor;
        }
    }
}
