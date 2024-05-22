using System;

namespace ColegioUML
{

    public class Colegio
    {
        private List<Estudiante> estudiantes;
        private string nombre;
        private string direccion;
        private string telefono;
        private string director;
        private int capacidad;
        private List<string> profesores;
        private List<string> cursos;

        public Colegio(string nombre, string direccion, string telefono, string director, int capacidad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.director = director;
            this.capacidad = capacidad;
        }

        public void matricularEstudiante(Estudiante estudiante, string curso)
        {
            if (estudiantes.Count < capacidad)
            {
                if (curso.Contains(curso))
                {
                    estudiante.inscribirCurso(curso);
                    estudiantes.Add(estudiante);
                }
                else
                {
                    Console.WriteLine("El curso no se imparte en este colegio");
                }

            }
            else
            {
                Console.WriteLine("Capacidad máxima Alcanzada");
            }
        }

        public void expulsarEstudiante(Estudiante estudiante)
        {
            estudiantes.Remove(estudiante);
        }

        public void contratarProfesor(string profesor)
        {
            profesores.Add(profesor);
        }

        public void despedirProfesor(string profesor)
        {
            profesores.Remove(profesor);
        }

        public void agregarCurso(string curso)
        {
            cursos.Add(curso);
        }

        public void eliminarCurso(string curso)
        {
            cursos.Remove(curso);
        }

        public string getDatosColegio()
        {
            return "Nombre: " + nombre + " Director: " + nombre + " Telefono: " + telefono;
        }

        public void setDatosColegio(string nombre, string direccion, string telefono, int capacidad, string director)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.capacidad = capacidad;
            this.director = director;
        }

        public List<string> obtenerCursos()
        {
            return cursos;
        }
    }
}