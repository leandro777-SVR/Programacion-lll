using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYS_03
{
    internal class Program
    {
        static void Main()
        {
            // USO DE ".LENGTH" Y BUCLE "FOR"

            Console.WriteLine(" .LENGTH Y FOR ");

            // Ejercicio 3.1
            int[] tasas_Refresco = { 60, 120, 144, 240 };
            Console.WriteLine("Evaluando " + tasas_Refresco.Length + " configuraciones de monitor.");
            for (int i = 0; i < tasas_Refresco.Length; i++)
            {
                Console.WriteLine("Índice " + i + ": " + tasas_Refresco[i] + "Hz");
            }

            // Ejercicio 3.2
            double[] pesos = { 4.5, 12.0, 25.5, 8.2 };
            Console.WriteLine("\nRegistros de peso (" + pesos.Length + " en total):");
            for (int i = 0; i < pesos.Length; i++)
            {
                Console.WriteLine("Mascota " + (i + 1) + " pesa: " + pesos[i] + " kg");
            }

            // Ejercicio 3.3
            int[] ventas_Diarias = { 3, 5, 2, 8, 4 };
            Console.WriteLine("\nReporte de los últimos " + ventas_Diarias.Length + " días:");
            for (int i = 0; i < ventas_Diarias.Length; i++)
            {
                Console.WriteLine("Día " + (i + 1) + ": " + ventas_Diarias[i] + " ventas");
            }

            // Ejercicio 3.4
            double[] probabilidad = { 0.15, 0.35, 0.25, 0.25 };
            Console.WriteLine("\nAnálisis de " + probabilidad.Length + " eventos posibles:");
            for (int i = 0; i < probabilidad.Length; i++)
            {
                Console.WriteLine("Evento " + i + " tiene una probabilidad de: " + probabilidad[i]);
            }

            // Ejercicio 3.5
            int[] reviews = { 5, 4, 5, 3, 5, 4 };
            Console.WriteLine("\nMostrando " + reviews.Length + " reseñas recientes:");
            for (int i = 0; i < reviews.Length; i++)
            {
                Console.WriteLine("Reseña " + i + ": " + reviews[i] + " estrellas");
            }


            Console.WriteLine("\nPresione Enter para finalizar el programa...");
            Console.ReadLine();
        }
    }
}
