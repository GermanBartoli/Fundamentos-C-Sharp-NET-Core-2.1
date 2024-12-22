using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ProyectoEscuela.Entidades
{
    internal class Curso
    {
        public string Nombre { get; set; }
        public string UniqueID { get; private set; }
        public TipoJornada Jornada { get; set; }

        public Curso(string nombre = "") {
            UniqueID = Guid.NewGuid().ToString();
        }

        // O

        public Curso()=> UniqueID = Guid.NewGuid().ToString();
    }
}
