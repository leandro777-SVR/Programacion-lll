using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYS_02
{
    internal class Program
    {
        static void Main()
        {// INICIALIZACIÓN DIRECTA Y FOREACH

            Console.WriteLine(" INICIALIZACIÓN Y FOREACH ");

            // Ejercicio 2.1
            string[] servicios_Criv = { "Branding", "Social Media", "Desarrollo Web", "Asesorías" };
            Console.WriteLine("Servicios de la agencia:");
            foreach (string servicios in servicios_Criv)
            {
                Console.WriteLine("- " + servicios);
            }

            // Ejercicio 2.2
            string[] razas = { "Bulldog", "Caniche", "Labrador", "Mestizo" };
            Console.WriteLine("\nRazas atendidas hoy:");
            foreach (string raza in razas)
            {
                Console.WriteLine("- " + raza);
            }

            // Ejercicio 2.3
            string[] categoria_Esmae = { "Iluminación", "Textiles", "Muebles", "Cerámica" };
            Console.WriteLine("\nCategorías disponibles:");
            foreach (string categoria in categoria_Esmae)
            {
                Console.WriteLine("- " + categoria);
            }

            // Ejercicio 2.4
            string[] stack_Dev = { "MongoDB", "Express", "React", "Node.js", "Next.js" };
            Console.WriteLine("\nTecnologías del proyecto:");
            foreach (string tech in stack_Dev)
            {
                Console.WriteLine("- " + tech);
            }

            // Ejercicio 2.5
            string[] herramientas = { "Lija", "Pincel", "Rodillo", "Esmalte Sintético" };
            Console.WriteLine("\nHerramientas preparadas:");
            foreach (string herramienta in herramientas)
            {
                Console.WriteLine("- " + herramienta);
            }


            Console.WriteLine("\nPresione Enter para pasar finalizar el programa...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
