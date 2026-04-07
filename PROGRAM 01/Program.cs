using System;

namespace PROGRAM_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE REGISTRO DE PRODUCTOS");

            string producto;
            string codigo;
            int stock;
            double precio;

            // VALIDAR NOMBRE DEL PRODUCTO (solo letras)
            while (true)
            {
                Console.Write("Ingresa nombre del producto: ");
                producto = Console.ReadLine();

                if (EsSoloTexto(producto))
                    break;
                else
                    Console.WriteLine("ERROR: Solo se permiten letras.");
            }

            // VALIDAR CATEGORIA
            while (true)
            {
                Console.Write("Ingresa categoria del producto: ");
                codigo = Console.ReadLine();

                if (EsSoloTexto(codigo))
                    break;
                else
                    Console.WriteLine("ERROR: Solo se permiten letras.");
            }

            // VALIDAR STOCK
            while (true)
            {
                Console.Write("Ingresa stock: ");
                if (int.TryParse(Console.ReadLine(), out stock))
                    break;
                else
                    Console.WriteLine("ERROR: Debes ingresar un número entero.");
            }

            // VALIDAR PRECIO
            while (true)
            {
                Console.Write("Ingresa precio unitario (ej:1500.75): $ ");
                if (double.TryParse(Console.ReadLine(), out precio))
                    break;
                else
                    Console.WriteLine("ERROR: Debes ingresar un número decimal.");
            }

            // RESULTADOS
            Console.WriteLine("\nPRODUCTO INGRESADO");
            Console.WriteLine("PRODUCTO: " + producto);
            Console.WriteLine("CATEGORÍA: " + codigo);
            Console.WriteLine("PRECIO UNITARIO: $ " + precio);
            Console.WriteLine("STOCK DISPONIBLE: " + stock);
            Console.WriteLine("PRECIO TOTAL STOCK: $ " + precio * stock);

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
        }

        // FUNCION PARA VALIDAR TEXTO
        static bool EsSoloTexto(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return false;
            }
            return true;
        }
    }
}