using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.ValueObject
{
    public class Nombre
    {
        String valor;

        public Nombre(String valor)
        {
            this.valor = valor;
        }

        public String Valor()
        {
            return this.valor;
        }
    }
}