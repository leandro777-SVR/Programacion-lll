using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAM06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TIENDA ONLINE");

            // Ejemplo 1
            const int CUOTAS_SIN_INTERES = 3;
            int cuotasSeleccionadas = 6;
            bool tieneRecargo = cuotasSeleccionadas > CUOTAS_SIN_INTERES;

            Console.WriteLine("\n1. FINANCIACIÓN");
            Console.WriteLine("Máximo sin interés: " + CUOTAS_SIN_INTERES + " cuotas.");
            Console.WriteLine("Cuotas elegidas: " + cuotasSeleccionadas);
            Console.WriteLine("¿Aplica recargo (bool)?: " + tieneRecargo);


            // Ejemplo 2
            const double DESCUENTO_TRANSFERENCIA = 0.15;
            string medioDePago = "Transferencia";
            bool aplicaDescuento = medioDePago == "Transferencia";

            Console.WriteLine("\n2. PROMOCIONES DE PAGO");
            Console.WriteLine("Descuento por transferencia: " + (DESCUENTO_TRANSFERENCIA * 100) + "%");
            Console.WriteLine("¿Recibe descuento (bool)?: " + aplicaDescuento);


            // Ejemplo 3
            const int STOCK_MINIMO_ALERTA = 5;
            int stockEspejoRedondo = 2;
            bool requiereReposicion = stockEspejoRedondo <= STOCK_MINIMO_ALERTA;

            Console.WriteLine("\n3. CONTROL DE STOCK");
            Console.WriteLine("Alerta configurada en: " + STOCK_MINIMO_ALERTA + " unidades.");
            Console.WriteLine("Stock actual del Espejo Redondo: " + stockEspejoRedondo);
            Console.WriteLine("¿Requiere fabricar más (bool)?: " + requiereReposicion);


            // Ejemplo 4
            const int MAX_PESO_IMAGEN_MB = 2;
            double pesoImagenSubida = 3.5;
            bool imagenValida = pesoImagenSubida <= MAX_PESO_IMAGEN_MB;

            Console.WriteLine("\n4. PANEL DE ADMIN - SUBIDA DE PRODUCTOS");
            Console.WriteLine("Peso máximo permitido: " + MAX_PESO_IMAGEN_MB + "MB.");
            Console.WriteLine("Peso de la imagen subida: " + pesoImagenSubida + "MB.");
            Console.WriteLine("¿Se puede guardar la imagen (bool)?: " + imagenValida);


            // Ejemplo 5
            const bool MODO_MANTENIMIENTO = false;

            Console.WriteLine("\n5. ESTADO DEL SISTEMA");
            Console.WriteLine("¿La tienda está en mantenimiento?: " + MODO_MANTENIMIENTO);
            Console.WriteLine("¿Se permiten realizar compras?: " + !MODO_MANTENIMIENTO);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}
