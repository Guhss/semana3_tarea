using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Menu
    {
        private List<Salon> salones = new List<Salon>();

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Crear un salón");
                Console.WriteLine("2. Agregar un alumno a un salón");
                Console.WriteLine("3. Remover un alumno de un salón");
                Console.WriteLine("4. Calcular cantidad de aprobados en un salón");
                Console.WriteLine("5. Calcular cantidad de desaprobados en un salón");
                Console.WriteLine("6. Calcular promedio general en un salón");
                Console.WriteLine("7. Salir");
               

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Salon salon = new Salon();
                        salones.Add(salon);
                        Console.WriteLine("Se ha creado un nuevo salón.");
                        break;
                    case 2:
                        Console.Write("Ingrese el nombre del salón: ");
                        string nombreSalon = Console.ReadLine();
                        Salon salonEncontrado = salones.Find(s => s.GetHashCode().ToString() == nombreSalon);
                        if (salonEncontrado != null)
                        {
                            Console.Write("Nombre del alumno: ");
                            string nombreAlumno = Console.ReadLine();
                            Console.Write("Nota 1: ");
                            float nota1 = float.Parse(Console.ReadLine());
                            Console.Write("Nota 2: ");
                            float nota2 = float.Parse(Console.ReadLine());
                            Console.Write("Nota 3: ");
                            float nota3 = float.Parse(Console.ReadLine());
                            Alumno alumno = new Alumno(nombreAlumno, nota1, nota2, nota3);
                            salonEncontrado.RegistrarAlumno(alumno);
                            Console.WriteLine("Alumno registrado en el salón.");
                        }
                        else
                        {
                            Console.WriteLine("Salón no encontrado.");
                        }
                        break;
                    case 3:
                        Console.Write("Ingrese el nombre del salón: ");
                        string nombreSalonRemover = Console.ReadLine();
                        Salon salonEncontradoRemover = salones.Find(s => s.GetHashCode().ToString() == nombreSalonRemover);
                        if (salonEncontradoRemover != null)
                        {
                            Console.Write("Nombre del alumno a remover: ");
                            string nombreAlumnoRemover = Console.ReadLine();
                            salonEncontradoRemover.RemoverAlumno(nombreAlumnoRemover);
                            Console.WriteLine("Alumno removido del salón.");
                        }
                        else
                        {
                            Console.WriteLine("Salón no encontrado.");
                        }
                        break;
                    case 4:
                        Console.Write("Ingrese el nombre del salón: ");
                        string nombreSalonAprobados = Console.ReadLine();
                        Salon salonEncontradoAprobados = salones.Find(s => s.GetHashCode().ToString() == nombreSalonAprobados);
                        if (salonEncontradoAprobados != null)
                        {
                            int cantidadAprobados = salonEncontradoAprobados.CalcularCantidadAprobados();
                            Console.WriteLine($"Cantidad de aprobados en el salón: {cantidadAprobados}");
                        }
                        else
                        {
                            Console.WriteLine("Salón no encontrado.");
                        }
                        break;
                    case 5:
                        Console.Write("Ingrese el nombre del salón: ");
                        string nombreSalonDesaprobados = Console.ReadLine();
                        Salon salonEncontradoDesaprobados = salones.Find(s => s.GetHashCode().ToString() == nombreSalonDesaprobados);
                        if (salonEncontradoDesaprobados != null)
                        {
                            int cantidadDesaprobados = salonEncontradoDesaprobados.CalcularCantidadDesaprobados();
                            Console.WriteLine($"Cantidad de desaprobados en el salón: {cantidadDesaprobados}");
                        }
                        else
                        {
                            Console.WriteLine("Salón no encontrado.");
                        }
                        break;
                    case 6:
                        Console.Write("Ingrese el nombre del salón: ");
                        string nombreSalonPromedio = Console.ReadLine();
                        Salon salonEncontradoPromedio = salones.Find(s => s.GetHashCode().ToString() == nombreSalonPromedio);
                        if (salonEncontradoPromedio != null)
                        {
                            double promedioGeneral = salonEncontradoPromedio.CalcularPromedioGeneral();
                            Console.WriteLine($"Promedio general del salón: {promedioGeneral}");
                        }
                        else
                        {
                            Console.WriteLine("Salón no encontrado.");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Saliendo del programa...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                   
                }
            }
        }
    }
}
