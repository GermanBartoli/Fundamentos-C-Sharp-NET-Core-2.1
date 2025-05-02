using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ProyectoEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            var linea = "".PadLeft(tam,'=');
            WriteLine("".PadLeft(tam,'='));
            //WriteLine("=====================");
            //Console.WriteLine("=====================");
        }

        public static void WriteTitle(string titulo)
        {
            DibujarLinea(titulo.Length + 4);
            WriteLine($"|  {titulo}  |");
            DibujarLinea(titulo.Length + 4);
            //WriteLine("=====================");
            //Console.WriteLine("=====================");
        }

        public static void Beep(int hz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while(cantidad-- > 0)
            {
                Console.Beep(hz, tiempo);
            }
        }
    }
}
