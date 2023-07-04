using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion.PantallasUIConsola
{
    public class UiConsolaMenu
    {
        public char Ejecutar()
        {
            Console.Clear();
            String cadena =
            "MENU\n" +
            "...............................................................................................\n\n" +
            "0.Registrar Pokemon\n" +
            "1.Buscar Pokemon\n" +
            "2.Todos los Pokemones\n" +
            "3.Eliminar Pokemon\n" +
            "4.Modificar Pokemon\n" +
            "5.Registrar Entrenador\n" +
            "6.Buscar Entrenador\n" +
            "7.Todos los Entrenadores\n" +
            "8.Eliminar Entrenador\n" +
            "9.Modificar Entrenador\n";

            Console.WriteLine(cadena);
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

           // Console.Write("Ingrese una opción para continuar: ");

            return caracter;
        }
    }
}
