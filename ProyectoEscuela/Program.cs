﻿using System;
using ProyectoEscuela.Entidades;

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
            Console.ReadLine();
            Console.WriteLine(arregloCursos[0].Nombre);
            Console.WriteLine("Imprimir Cursos");
            ImprimirCursos(arregloCursos);

        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, Id: {arregloCursos[contador].UniqueID}");
                contador++;
            }
        }
    }
}
