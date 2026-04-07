using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAM_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // EJEMPLO 1: EL DECIMAL POR DEFECTO(double)
        Console.WriteLine("BLOQUE 1: DECIMAL COMÚN (double)");

            double pesoMascota = 25.5;

            Console.WriteLine("1. TIPO DOUBLE:");
            Console.WriteLine("   Peso registrado de la mascota: " + pesoMascota + " kg");

            Console.WriteLine("\nPresiona ENTER para continuar.");
            Console.ReadLine();
            Console.Clear();


            // EJEMPLO 2: DECIMAL PARA VIDEOJUEGOS (float)
            Console.WriteLine("BLOQUE 2: DECIMAL LIGERO (float)");

            float sensibilidadMouse = 1.25f;

            Console.WriteLine("2. TIPO FLOAT:");
            Console.WriteLine("   Sensibilidad actual: " + sensibilidadMouse);

            Console.WriteLine("\nPresiona ENTER para continuar.");
            Console.ReadLine();
            Console.Clear();


            // EJEMPLO 3: DECIMAL PARA DINERO (decimal)
            Console.WriteLine("BLOQUE 3: DECIMAL FINANCIERO (decimal)");

            decimal precioGpu = 285999.99m;

            Console.WriteLine("3. TIPO DECIMAL:");
            Console.WriteLine("   Precio de la placa de video: $" + precioGpu);

            Console.WriteLine("\nPresiona ENTER para continuar.");
            Console.ReadLine();
            Console.Clear();


            // EJEMPLO 4: MATEMÁTICA CON DOUBLE
            Console.WriteLine("BLOQUE 4: CÁLCULOS CON DOUBLE");

            double notaParcial1 = 8.5;
            double notaParcial2 = 7.0;
            double promedioUtn = (notaParcial1 + notaParcial2) / 2.0;

            Console.WriteLine("4. OPERACIONES CON DOUBLE:");
            Console.WriteLine("   Tu promedio final es: " + promedioUtn);

            Console.WriteLine("\nPresiona ENTER para continuar.");
            Console.ReadLine();
            Console.Clear();


            // EJEMPLO 5: MATEMÁTICA CON DECIMAL (PRESUPUESTOS)
            Console.WriteLine("BLOQUE 5: CÁLCULOS FINANCIEROS");

            decimal valorHora = 9600.60m;
            decimal horasTrabajadas = 25.5m;
            decimal totalFacturar = valorHora * horasTrabajadas;

            Console.WriteLine("5. OPERACIONES CON DECIMAL:");
            Console.WriteLine("   Costo por hora: $" + valorHora);
            Console.WriteLine("   Total a facturar al cliente: $" + totalFacturar);

            Console.WriteLine("\nPresiona ENTER para cerrar el programa.");
            Console.ReadLine();
        }
    }
}
