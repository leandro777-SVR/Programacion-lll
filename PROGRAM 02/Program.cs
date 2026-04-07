using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAM_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Datos de Alumno ");

            string nombre = "Leandro Oscar Flores";
            int edad = 24;
            int legajo = 63770;
            string comision = "Comision 8 - TUP";
            string profe = "Rodrigo Esper";

            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("   Para números sin decimales, como edad o cantidad.");
            Console.WriteLine("   Edad: " + edad);
            Console.WriteLine("   Legajo: " + legajo);
            Console.WriteLine("   " + comision);
            Console.WriteLine("   Profe: " + profe);

            Console.WriteLine("\n");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

        }
    }
}
