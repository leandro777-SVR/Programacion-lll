using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYS_01
{
    internal class Program
    {
        static void Main(string[] args)
        {  // FUNDAMENTOS DE ARREGLOS 

            Console.WriteLine(" Ejercicios 1.1 a 1.5 ");

            // Ejercicio 1.1
            int[] edadMascotas = new int[3];
            edadMascotas[0] = 2;
            edadMascotas[1] = 5;
            edadMascotas[2] = 10;
            Console.WriteLine("Edad mascota 1: " + edadMascotas[0]);

            // Ejercicio 1.2
            double[] preciosDeco = new double[2];
            preciosDeco[0] = 15500.50;
            preciosDeco[1] = 8900.00;
            Console.WriteLine("Precio artículo 2: $" + preciosDeco[1]);

            // Ejercicio 1.3
            int[] notasExam = new int[4];
            notasExam[0] = 8;
            notasExam[1] = 7;
            notasExam[2] = 9;
            notasExam[3] = 10;
            Console.WriteLine("Última nota: " + notasExam[3]);

            // Ejercicio 1.4
            int[] temperaturas_GPU = new int[3];
            temperaturas_GPU[0] = 65;
            temperaturas_GPU[1] = 72;
            temperaturas_GPU[2] = 78;
            Console.WriteLine("Temperatura máxima registrada: " + temperaturas_GPU[2] + "°C");

            // Ejercicio 1.5
            int[] horas_Agencia = new int[2];
            horas_Agencia[0] = 15;
            horas_Agencia[1] = 22;
            Console.WriteLine("Horas proyecto web: " + horas_Agencia[0]);

            Console.WriteLine("\nPresione Enter para pasar finalizar el programa...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
