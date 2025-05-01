using System;
using System.Collections.Generic;

namespace ProyectoEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        int anioCreacion;
        string ciudad;

        public string Nombre
        {
            get { return "Copia: " + nombre; }
            set { nombre = value.ToUpper(); }
        }

        public int AnioCreacion
        {
            get; set;
        }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TipoEscuela TipoEscuela { get; set; }

        public Curso[] arrayCursos { get; set; }

        public List<Curso> lstCursos { get; set; }

        public void Timbrar()
        {
            //Todo
            Console.Beep(2000, 3000);
        }

        public Escuela(string nombre, int anioCreacion, TipoEscuela tipoEscuela, string pais = "", string ciudad = "")
        {
            (Nombre, AnioCreacion)  = (nombre, anioCreacion);
            Pais = pais;
            this.ciudad = ciudad;
        }

        // Igualación por tuplas
        public Escuela(string nombre, int anioCreacion) => (Nombre, AnioCreacion) = (nombre, anioCreacion);

        public override string ToString()
        {
            return $"Nombre: \"{nombre}\n \n" +
            $"Pais: {Pais} \n" +
            $"{Environment.NewLine}" +
            $"Ciudad: {Ciudad}";
        }
    }
}
