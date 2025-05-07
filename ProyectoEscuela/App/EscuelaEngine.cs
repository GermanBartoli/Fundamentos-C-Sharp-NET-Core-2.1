using ProyectoEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
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

            CargarCursos();

            //foreach (var curso in Escuela.lstCursos)
            //{
            //    curso.lstAlumnos.AddRange(GenerarAlumnosAlAzar());

            //}

            CargarAsignaturas();

            CargarEvaluaciones();

        }

        // Implementar la carga aleatoria de evaluaciones
        // 5 evaluaciones x asignatura por cada alumno de cada curso
        // Notas al azar entre 0.0 y 5.0

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.lstCursos)
            {
                foreach (var asignatura in curso.lstAsignaturas)
                {
                    foreach (var alumno in curso.lstAlumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);

                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluacion
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{i+1}",

                                Nota = (float)(5 * rnd.NextDouble()),
                                Alumno = alumno
                            };

                            alumno.lstEvaluaciones.Add(ev);
                        }
                    }
                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.lstCursos)
            {
                List<Asignatura> lstAsignaturas = new List<Asignatura>()
                {
                    new Asignatura{Nombre = "Matemáticas"},
                    new Asignatura{Nombre = "Educación Física"},
                    new Asignatura{Nombre = "Castellano"},
                    new Asignatura{Nombre = "Ciencias Naturales"},
                };
                curso.lstAsignaturas.AddRange(lstAsignaturas);
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "nombre1", "nombre2", "a", "b", "c" };
            string[] nombre2 = { "nombre1", "nombre2" };
            string[] apellido1 = { "apellido1", "apellido2" };

            // Producto cartesiano
            var lstAlumnos = from n1 in nombre1
                             from n2 in nombre2
                             from a1 in apellido1
                             select new Alumno { Nombre= $"{n1} {n2} {a1}" };

            return lstAlumnos.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();
            
        }

        private void CargarCursos()
        {
            Escuela.lstCursos = new List<Curso>();

            Escuela.lstCursos.Add(new Curso { Nombre="101", Jornada = TipoJornada.Mañana });

            Escuela.lstCursos.Add(new Curso { Nombre="102", Jornada = TipoJornada.Mañana });

            Escuela.lstCursos.Add(new Curso { Nombre="103", Jornada = TipoJornada.Mañana });

            Escuela.lstCursos.Add(new Curso { Nombre="104", Jornada = TipoJornada.Mañana });

            Escuela.lstCursos.Add(new Curso { Nombre="105", Jornada = TipoJornada.Mañana });

            Escuela.lstCursos.Add(new Curso { Nombre="106", Jornada = TipoJornada.Mañana });

            Random rnd = new Random();

            foreach (var c in Escuela.lstCursos)
            {
                int cantRandom = rnd.Next(5, 20);
                c.lstAlumnos = GenerarAlumnosAlAzar(cantRandom);
            }

        }
    }
}
