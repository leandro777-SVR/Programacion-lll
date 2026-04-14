using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PORGRAM05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ESTADO ACADÉMICO");

            // Ejemplo 1
            bool promocionaMateria = true;
            Console.WriteLine("1. Promociona Programación 3?: " + promocionaMateria);

            // Ejemplo 2
            bool entregoTrabajoFinal = false;
            Console.WriteLine("2. Entregó el trabajo final integrador (React/Node)?: " + entregoTrabajoFinal);

            // Ejemplo 3
            bool asistenciaCumplida = true;
            Console.WriteLine("3. Cumple con el 75% de asistencia requerido?: " + asistenciaCumplida);

            // Ejemplo 4
            bool esAlumnoRegular = true;
            Console.WriteLine("4. Mantiene la condición de alumno regular en la UTN?: " + esAlumnoRegular);

            // Ejemplo 5
            bool aproboCorrelativas = true;
            Console.WriteLine("5. Tiene aprobadas todas las materias correlativas (Ej. Programación 2)?: " + aproboCorrelativas);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

        }
    }
}
