﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoEscuela.Entidades
{
    public class Alumno
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public List<Evaluacion> lstEvaluaciones;

        //public Alumno() => UniqueId = Guid.NewGuid().ToString();

        public Alumno() {
            UniqueId = Guid.NewGuid().ToString();
            lstEvaluaciones = new List<Evaluacion>();
        }
    }
}
