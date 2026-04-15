using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boliche_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[20];
            int[] edades = new int[20];

            // CARGA DE DATOS
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Ingrese nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ingrese edad: ");
                edades[i] = int.Parse(Console.ReadLine());
            }

            // MAYORES DE 30
            Console.WriteLine("\nPUEDEN INGRESAR:");
            for (int i = 0; i < 20; i++)
            {
                if (edades[i] > 30)
                {
                    Console.WriteLine(nombres[i] + " - " + edades[i]);
                }
            }

            // MENORES O IGUALES A 30
            Console.WriteLine("\nNO PUEDEN INGRESAR:");
            for (int i = 0; i < 20; i++)
            {
                if (edades[i] <= 30)
                {
                    Console.WriteLine(nombres[i] + " - " + edades[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
