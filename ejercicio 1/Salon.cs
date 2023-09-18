using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Salon
    {
        private List<Alumno> alumnos = new List<Alumno>();

        public void RegistrarAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        public void RemoverAlumno(string nombre)
        {
            Alumno alumno = alumnos.Find(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (alumno != null)
            {
                alumnos.Remove(alumno);
            }
        }

        public int CalcularCantidadAprobados()
        {
            return alumnos.Count(a => a.CalcularPromedioTLS() >= 12.5);
        }

        public int CalcularCantidadDesaprobados()
        {
            return alumnos.Count(a => a.CalcularPromedioTLS() < 12.5);
        }

        public List<Alumno> ObtenerAprobados()
        {
            return alumnos.FindAll(a => a.CalcularPromedioTLS() >= 12.5);
        }

        public List<Alumno> ObtenerDesaprobados()
        {
            return alumnos.FindAll(a => a.CalcularPromedioTLS() < 12.5);
        }

        public double CalcularPromedioGeneral()
        {
            float sumaPromedios = alumnos.Sum(a => a.CalcularPromedioTLS());
            return sumaPromedios / alumnos.Count;
        }

    }
}
