using System;
using System.Collections.Generic;
using ProyectoEscuela.App;
using ProyectoEscuela.Entidades;
using ProyectoEscuela.Util;
using static System.Console;
namespace ProyectoEscuela
{
    class Escuela2{
        public string nombre;
        public string direccion;
        public int anioFundacion;
        public string ceo = "ceo";

        public void Timbrar(){
            //Todo
            Console.Beep(2000,3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var escuela = new Escuela("Nombre de la escuela", 2000, TipoEscuela.Primaria, ciudad: "Córdoba", pais: "Argentina");

            escuela.Nombre = "Platzi Academy";
            escuela.Ciudad = "Anónima";
            escuela.AnioCreacion = 2000;

            System.Console.WriteLine("Timbre");
            //miEscuela.Timbrar();

            escuela.TipoEscuela = TipoEscuela.Primaria;

            System.Console.WriteLine(escuela);

            var arregloCursos = new Curso[3];

            //arregloCursos[0] = new Curso() {
            //    Nombre="101", 
            //};

            var curso1 = new Curso()
            {
                Nombre="101",
            };


            arregloCursos[0] = curso1;

            var curso2 = new Curso()
            {
                Nombre="102",
            };

            arregloCursos[1] = curso2;

            var curso3 = new Curso()
            {
                Nombre="103",
            };

            arregloCursos[2] = curso3;


            Console.WriteLine("==============");
            Console.WriteLine(curso1.Nombre + "," + curso1.UniqueID);
            Console.WriteLine(curso2.Nombre + "," + curso2.UniqueID);
            Console.WriteLine(curso3.Nombre + "," + curso3.UniqueID);
            Console.WriteLine("Presione ENTER para continuar");
            //Console.ReadLine();
            Console.WriteLine(arregloCursos[0].Nombre);
            Console.WriteLine("Imprimir Cursos While");
            ImprimirCursosWhile(arregloCursos);

            Console.WriteLine("Imprimir Cursos Do While");
            ImprimirCursosDoWhile(arregloCursos);

            Console.WriteLine("Imprimir Cursos For");
            ImprimirCursosFor(arregloCursos);

            Console.WriteLine("Imprimir Cursos ForEach");
            ImprimirCursosForEach(arregloCursos);

            var arregloCursosImpresion = new Curso[3]
            {
                new Curso()
                {
                    Nombre = "101"
                },
                new Curso()
                {
                    Nombre = "102"
                },
                 new Curso()
                {
                    Nombre = "103"
                },
            };

            //Curso[] arregloCursosImpresion2 =
            escuela.arrayCursos = new Curso[]
            {
                new Curso()
                {
                    Nombre = "101"
                },
                new Curso()
                {
                    Nombre = "102"
                },
                 new Curso()
                {
                    Nombre = "103"
                },
            };

            escuela.arrayCursos = arregloCursosImpresion;

            ImprimirCursosEscuela(escuela);

            //Clase 19

            bool rta = 10 == 10;
            int cantidad = 10;

            if (!rta)
            {
                WriteLine("Se cumplio la condición 1 ");
            }
            else if (cantidad > 5)
            {
                WriteLine("Se cumplió la condición 2");
            }
            else {
                WriteLine("No se cumplió la condición 1 y 2");
            }

            if (cantidad > 5 && rta == false)
            {
                WriteLine("se cumplió la condición 3");
            }

            if (cantidad > 5 && rta != false)
            {
                WriteLine("se cumplió la condición 4");
            }

            cantidad = 10;
            if ((cantidad > 5 || rta) && (cantidad % 5 == 0))
            {
                WriteLine("se cumplió la condición 5");
            }
            // Clase 20
            // https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/operators/

            // Clase 21
            //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/collections

            // Clase 22 Uso de Colecciones en C#: Listas y Operaciones Básicas
            WriteLine("Clase 22");
            //System.Collections.Generic.
            //System.Collections.Specialized;
            var listaCursos = new List<Curso>()
            {
                new Curso()
                {
                    Nombre = "101"
                },
                new Curso()
                {
                    Nombre = "102"
                },
                 new Curso()
                {
                    Nombre = "103"
                },
            };

            escuela.lstCursos = listaCursos;

            escuela.lstCursos.Add(new Curso { Nombre="102", Jornada = TipoJornada.Mañana });

            var lstaCursos22 = escuela.lstCursos;
            escuela.lstCursos.AddRange(lstaCursos22);

            escuela.lstCursos.Remove(curso3);

            // escuela.lstCursos.Clear();

            // Clase 23 Eliminación de Elementos en Listas Usando Criterios en C#

            Curso tmp = new Curso() {Nombre = "101-Vacacional", Jornada = TipoJornada.Noche  };

            Predicate<Curso> miAlgoritmo = Predicate ;

            // Llama a la función por cada uno que está en la lista
            //Apuntador función
            escuela.lstCursos.RemoveAll(miAlgoritmo);

            escuela.lstCursos.Add(tmp);

            WriteLine("Curso.Hash: " + tmp.GetHashCode());

            ImprimirCursosEscuelaLst(escuela);

            escuela.lstCursos.Remove(tmp);

            // Clase 24: Delegados y Expresiones Lambda en C#

            // Inferencias de tipos
            escuela.lstCursos.RemoveAll(Predicate);

            // Delegado o expreción lambda
            escuela.lstCursos.RemoveAll(
                delegate (Curso curso)
                {
                    return curso.Nombre == "101";
                }
            );

            //Más compacto, lambda
            escuela.lstCursos.RemoveAll((Curso curso) => curso.Nombre == "101");
            escuela.lstCursos.RemoveAll((curso) => curso.Nombre == "101" && curso.Jornada == TipoJornada.Mañana);

            // Clase 25: Refactorización y Organización de Código en C#
            WriteLine("Clase 25");
            WriteLine("Clase 25");
            var engine = new EscuelaEngine();
            engine.Inicializar();

            // Clase 26: Clases estáticas en C#: Uso y beneficios prácticos
            Printer.DibujarLinea(20);

            Printer.WriteTitle("Bienvenidos a la Escuela");

            Printer.Beep(10000, cantidad:10);
            ImprimirCursosEscuelaLst(engine.Escuela);
        }

        private static bool Predicate(Curso obj)
        {
            return obj.Nombre == "101";
        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                WriteLine($"Nombre: {arregloCursos[contador].Nombre}, Id: {arregloCursos[contador].UniqueID}");
                contador++;
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do
            {
                Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, Id: {arregloCursos[contador].UniqueID}");
                contador++;
            //} while (++contador++ < arregloCursos.Length);
            } while (contador < arregloCursos.Length);
        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                Console.WriteLine($"Nombre: {arregloCursos[i].Nombre}, Id: {arregloCursos[i].UniqueID}");

            }
        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                Console.WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueID}");
            }
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Console.WriteLine("==============");
            Console.WriteLine("Cursos de la Escuela");

            if (escuela?.arrayCursos != null)
            foreach (var curso in escuela.arrayCursos)
            {
                WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueID}");

            }

            Console.WriteLine("==============");
        }

        private static void ImprimirCursosEscuelaLst(Escuela escuela)
        {
            Printer.WriteTitle("Impresión Cursos de la Escuela LST");

            if (escuela?.arrayCursos != null)
                foreach (var curso in escuela.lstCursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueID}");

                }

            Console.WriteLine("==============");
        }
    }
}
