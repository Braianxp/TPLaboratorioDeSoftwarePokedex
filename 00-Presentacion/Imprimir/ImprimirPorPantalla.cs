using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion.Imprimir
{
    static class ImprimirPorPantalla
    {
        public static void Ejecutar(String contenido)
        {
            List<String> oraciones = contenido.Split('\n').ToList();
            String consolaAbierta = "";
            String consolaCerrada = "";
            String consolaContenido = "";
            String consola = "";

            consolaAbierta =
                "##############################################################################################################\n" +
                "####                                                     ,;;,                                             ####\n" +
                "####                                                   ,;;**'                                             ####\n" +
                "####                                                   `                                                  ####\n" +
                "####                       -;%&&&&-              %%,   ,;;,    %&  &%                                     ####\n" +
                "####                    ‗&&&&&&&&&&&       -&&  %&&% ;&&&&&%   &&&  &%      -&%&%                         ####\n" +
                "####                    %&&&&&%  '&&%       &&&&&&% !%&' ;&-   &&& &&&  ,%%, %&&& '&&&                    ####\n" +
                "####                      `&&&&,  )&> ;&!%%, &&&&   %&&,-'  ,  &&&&&&& %&%&&& &&&>!&&%                    ####\n" +
                "####                       '&&&%,%&! %& &'%& &&&&&%,`&&&&&&&&- && &&& %& `' &% &&%%&&                     ####\n" +
                "####                        -&&&&&- %&&, ,%& %&`'&&&%,-*%**- ,&&% & % &&%--&& %&&&&&%                     ####\n" +
                "####                         -&&&>  %&&&&&&! &&   `%&&%%,    `***   %_'&&&&& %& %&&&                      ####\n" +
                "####                          &&&%   '&&&&'  &&       -%;           !&%,''' %&% %&&%                      ####\n" +
                "####                          '&&&,                                             %&%                       ####\n" +
                "####                           -&!&                                             %&%                       ####\n" +
                "####                                                                                                      ####\n" +
                "##############################################################################################################\n" +
                "##############################################################################################################\n" +
                "####                                                                                                      ####\n";

            foreach (String oracion in oraciones)
            {
                if(oracion.Length < 96) {
                    int contador = 96;
                    contador = contador - oracion.Length;
                    consolaContenido = consolaContenido + "####   " + oracion;
                    for(int i = 0; i < contador; i++)
                    {
                        consolaContenido = consolaContenido + " ";
                    }
                    consolaContenido = consolaContenido + "   ####\n";
                }
                else
                {
                    int contador = 96;
                    
                    List<String> palabras = oracion.Split(' ').ToList();
                    
                    consolaContenido = consolaContenido + "####   ";

                    foreach(String palabra in palabras)
                    {
                        int cantidadDeCaracteres = palabra.Length;
                        if(cantidadDeCaracteres < contador)
                        {
                            consolaContenido = consolaContenido + " " + palabra;
                            contador = contador - cantidadDeCaracteres -1;
                        }
                        else
                        {
                            consolaContenido = consolaContenido + "\n" + "###   " + palabra;
                            contador = 96;
                        }
                    }
                }
            }

            consolaCerrada =
                "####                                                                                                      ####\n" +
                "####                                                                                                v1.2  ####\n" +
                "##############################################################################################################\n";

            consola = consolaAbierta + consolaContenido + consolaCerrada;

            Pintar(consola);
        }

        private static void Pintar(String consola)
        {
            List<char> caracteres = consola.ToList();
            Console.Clear();
            foreach (char c in caracteres)
            {

                int valorAscii = Convert.ToInt32(c);
                //todas las letras y numeros en verde
                if ((valorAscii > 45 && valorAscii < 59) || (valorAscii > 62 && valorAscii < 91) || (valorAscii > 96 && valorAscii < 177))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(c);
                }
                else
                {
                    switch (c)
                    {
                        //caracter # en rojo
                        case '#':
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(c);
                            break;

                        //todos los demas caracteres en amarillo
                        default:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(c);
                            break;
                    }
                }
            }
        }
    }
}
