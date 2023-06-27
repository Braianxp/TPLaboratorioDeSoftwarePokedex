using _00_Presentacion.Imprimir;
using _02_Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion.PantallasUIAscii
{
    public class UiAsciiRegistrarPokemon
    {
        public char Ejecutar()
        {
            String[] atributosPokemon = {"Nombre","N°","Tipo","Evolucion","Habilidad"};
            String[] informacionPokemon = new String[5];
            String contenido;

            contenido = "";
            contenido = contenido + "REGISTRAR POKEMON\n" +
                contenido + "...............................................................................................\n\n" +
                atributosPokemon[0] + ": " + informacionPokemon[0] + "\n" +
                atributosPokemon[1] + ": " + informacionPokemon[1] + "\n" +
                atributosPokemon[2] + ": " + informacionPokemon[2] + "\n" +
                atributosPokemon[3] + ": " + informacionPokemon[3] + "\n" +
                atributosPokemon[4] + ": " + informacionPokemon[4] + "\n";

            ImprimirPorPantalla.Ejecutar(contenido);

            for (int i = 0; i<informacionPokemon.Length;i++)
            {
                
                char caracter;
                String entrada;
                do
                {
                    Console.Write("Ingrese un valor para " + atributosPokemon[i] + ": ");
                    entrada = Console.ReadLine();

                    if (entrada.Length >= 1)
                    {
                        caracter = entrada[0];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ADVERTENCIA! Debe ingresar algun valor para continuar.");
                    }
                } while (true);

                informacionPokemon[i] = entrada;
                contenido = "";
                contenido = contenido + "Registrar Pokemon\n\n" +
                    atributosPokemon[0] + ": " + informacionPokemon[0] + "\n" +
                    atributosPokemon[1] + ": " + informacionPokemon[1] + "\n" +
                    atributosPokemon[2] + ": " + informacionPokemon[2] + "\n" +
                    atributosPokemon[3] + ": " + informacionPokemon[3] + "\n" +
                    atributosPokemon[4] + ": " + informacionPokemon[4] + "\n";
                ImprimirPorPantalla.Ejecutar(contenido);
            }
           
            Console.WriteLine("Pokemon registrado presione cualquier boton para continuar...");
            Console.ReadLine();
            return '2';
        }
    }
}
