using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAM_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EJEMPLO 1: CADENA DE TEXTO BÁSICA (string)
            Console.WriteLine("--- BLOQUE 1: NOMBRES Y TEXTOS ---");

            string nombrePerro = "Puppy";
            string raza = "Dachshund";

            Console.WriteLine("1. TIPO STRING:");
            Console.WriteLine("   Mascota: " + nombrePerro + " - Raza: " + raza);

            Console.WriteLine("\nPresiona ENTER para continuar.");
            Console.ReadLine();
            Console.Clear();


            // EJEMPLO 2: CARÁCTER INDIVIDUAL (char)
            Console.WriteLine("--- BLOQUE 2: CARACTERES ÚNICOS ---");

            char inicial = 'S';
            char rango = 'A';

            Console.WriteLine("2. TIPO CHAR:");
            Console.WriteLine("   Tu inicial es: " + inicial);
            Console.WriteLine("   Rango de desempeño: " + rango);

            Console.WriteLine("\nPresiona ENTER para continuar.");
            Console.ReadLine();
            Console.Clear();


            // EJEMPLO 3: CONCATENACIÓN DE TEXTO
            Console.WriteLine("--- BLOQUE 3: UNIÓN DE TEXTOS ---");

            string facultad = "UTN";
            string carrera = "Tecnicatura en Programación";
            string infoCompleta = facultad + " - " + carrera;

            Console.WriteLine("3. CONCATENACIÓN (+):");
            Console.WriteLine("   Estudios: " + infoCompleta);

            Console.WriteLine("\nPresiona ENTER para continuar.");
            Console.ReadLine();
            Console.Clear();


            // EJEMPLO 4: TEXTO CON FORMATO (Escapes)
            Console.WriteLine("--- BLOQUE 4: CARACTERES ESPECIALES ---");

            // \n sirve para saltar de línea, \t para tabular (dar espacio)
            string listaHardware = "Componentes:\n\t- Procesador\n\t- Memoria RAM\n\t- Monitor 165Hz";

            Console.WriteLine("4. SECUENCIAS DE ESCAPE:");
            Console.WriteLine(listaHardware);

            Console.WriteLine("\nPresiona ENTER para continuar.");
            Console.ReadLine();
            Console.Clear();


            // EJEMPLO 5: MÉTODOS DE TEXTO (Mayúsculas/Minúsculas)
            Console.WriteLine("--- BLOQUE 5: TRANSFORMACIÓN DE TEXTO ---");

            string ciudad = "San Miguel de Tucumán";

            Console.WriteLine("5. MANIPULACIÓN:");
            Console.WriteLine("   Todo en mayúsculas: " + ciudad.ToUpper());
            Console.WriteLine("   Todo en minúsculas: " + ciudad.ToLower());
            Console.WriteLine("   Cantidad de letras (incluyendo espacios): " + ciudad.Length);

            Console.WriteLine("\nPresiona ENTER para finalizar la guía.");
            Console.ReadLine();
        }
    }
}
