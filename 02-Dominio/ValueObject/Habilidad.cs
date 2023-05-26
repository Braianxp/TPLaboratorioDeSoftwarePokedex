using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.ValueObject
{
    public class Habilidad
    {
        String valor;

        public Habilidad(String valor)
        {
            this.valor = valor;
        }

        public String Valor()
        {
            return this.valor;
        }
    }
}
