using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColegioUML
{
    public class Estudiante
    {
        private string id;
        private string nombre;
        private string apellido;
        private string direccion;
        private string telefono;
        private string email;
        private List<string> cursosIncritos;
        private Colegio colegio;

        public Estudiante(string id, string nombre, string apellido, string direccion, string telefono, string email, Colegio colegio)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.colegio = colegio;
        }



        public void inscribirCurso(string curso)
        {
            if (colegio.obtenerCursos().Contains(curso))
            {
                cursosIncritos.Add(curso);
            }
            else
            {
                Console.Write("Curso no se imparte en ese colegio");
            }
        }

        public void abandonarCurso()
        {
            throw new System.NotImplementedException();
        }

        public int obtenerEdad()
        {
            throw new System.NotImplementedException();
        }

        public List<string> obtenerCursosIncritos()
        {
            return cursosIncritos;
        }

        public void setDatosContacto(string direccion, string telefono, string email)
        {
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
        }

        public string getDatosEstudiante()
        {
            return "Id: " + id + "nombre: " + nombre;
        }
    }
}