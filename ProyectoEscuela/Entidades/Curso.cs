using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ProyectoEscuela.Entidades
{
    public class Curso
    {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }
        public TipoJornada Jornada { get; set; }
        public List<Asignatura> lstAsignaturas { get; set; }
        public List<Alumno> lstAlumnos { get; set; }
        //public Curso(string nombre = "") {
        //    UniqueID = Guid.NewGuid().ToString();
        //}

        // O

        //public Curso()=> UniqueID = Guid.NewGuid().ToString();

        public Curso(string nombre = "")
        {
            UniqueID = Guid.NewGuid().ToString();
            Nombre = nombre;
            lstAsignaturas = new List<Asignatura>();
            lstAlumnos = new List<Alumno>();
        }
    }
}
