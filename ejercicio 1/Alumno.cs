using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Alumno
    {
        public string Nombre; 
        public float Nota1; 
        public float Nota2;
        public float Nota3; 

        public Alumno(string nombre, float nota1, float nota2, float nota3)
        {
            Nombre = nombre;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public float CalcularPromedioTLS()
        {
            return (Nota1 + Nota2 + 2*Nota3) / 4;
        }
    }
}
