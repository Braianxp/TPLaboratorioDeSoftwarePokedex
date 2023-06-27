using _00_Presentacion.Imprimir;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion.PantallasUIAscii
{
    public class UiAsciiMenu
    {
        public char Ejecutar()
        {

            String cadena =
            "MENU\n" +
            "...............................................................................................\n\n" +
            "1.Registrar Pokemon\n" +
            "2.Buscar Pokemon\n" +
            "3.Todos los Pokemones\n" +
            "4.Eliminar Pokemon\n" +
            "5.Registrar Entrenador\n" +
            "6.Buscar Entrenador\n" +
            "7.Todos los Entrenadores\n" +
            "8.Eliminar Entrenador\n" +
            "9.Asignar Pokemon\n" +
            "0.Cerrar\n";

            ImprimirPorPantalla.Ejecutar(cadena);
            char caracter;
            String entrada;
            do
            {
                Console.Write("Ingrese un numero de la lista de opciones para continuar: ");
                entrada = Console.ReadLine();

                if (entrada.Length >= 1)
                {
                    caracter = entrada[0];
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Debe ingresar exactamente un carácter. Inténtelo nuevamente.");
                }
            } while (true);

            Console.Write("Ingrese una opción para continuar: ");

            return caracter;
            
        }
    }
}
