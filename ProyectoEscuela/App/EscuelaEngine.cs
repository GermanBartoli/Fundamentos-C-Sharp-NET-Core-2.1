using ProyectoEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoEscuela.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Nombre de la escuela", 2000, TipoEscuela.Primaria, ciudad: "Córdoba", pais: "Argentina");

            Escuela.lstCursos = new List<Curso>();

            Escuela.lstCursos.Add(new Curso { Nombre="101", Jornada = TipoJornada.Mañana });

            Escuela.lstCursos.Add(new Curso { Nombre="102", Jornada = TipoJornada.Mañana });

            Escuela.lstCursos.Add(new Curso { Nombre="103", Jornada = TipoJornada.Mañana });

            Escuela.lstCursos.Add(new Curso { Nombre="104", Jornada = TipoJornada.Mañana });

            Escuela.lstCursos.Add(new Curso { Nombre="105", Jornada = TipoJornada.Mañana });

            Escuela.lstCursos.Add(new Curso { Nombre="106", Jornada = TipoJornada.Mañana });
        }
    }
}
