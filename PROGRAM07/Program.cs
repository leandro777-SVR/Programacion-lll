using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAM07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULOS FINANCIEROS Y LÓGICOS");

            // Ejemplo 1
            const decimal RECARGO_TARJETA = 0.15m;
            const char SIGNO_PESO = '$';

            decimal precioPlacaVideo = 650000.00m;
            decimal montoRecargo = precioPlacaVideo * RECARGO_TARJETA;
            decimal totalConTarjeta = precioPlacaVideo + montoRecargo;

            Console.WriteLine("\n1. PAGO CON TARJETA");
            Console.WriteLine("Precio base Placa de Video: " + SIGNO_PESO + precioPlacaVideo);
            Console.WriteLine("Recargo (15%): +" + SIGNO_PESO + montoRecargo);
            Console.WriteLine("Total a pagar: " + SIGNO_PESO + totalConTarjeta);



            // Ejemplo 2

            const decimal TASA_IVA = 0.21m;

            decimal precioProcesadorSinIVA = 180000.00m;
            decimal montoIVA = precioProcesadorSinIVA * TASA_IVA;
            decimal precioFinalProcesador = precioProcesadorSinIVA + montoIVA;

            Console.WriteLine("\n2. CÁLCULO DE IMPUESTOS");
            Console.WriteLine("Procesador (Sin IVA): " + SIGNO_PESO + precioProcesadorSinIVA);
            Console.WriteLine("IVA (21%): +" + SIGNO_PESO + montoIVA);
            Console.WriteLine("Precio Final: " + SIGNO_PESO + precioFinalProcesador);



            // Ejemplo 3

            const decimal COTIZACION_DOLAR = 1050.50m;
            const char SIGNO_DOLAR = 'U';

            decimal precioMouseGamerUSD = 60.00m;
            decimal precioConvertidoARS = precioMouseGamerUSD * COTIZACION_DOLAR;

            Console.WriteLine("\n3. CONVERSIÓN DE DIVISAS");
            Console.WriteLine("Precio en Dólares: " + SIGNO_DOLAR + SIGNO_PESO + precioMouseGamerUSD);
            Console.WriteLine("Cotización actual: " + SIGNO_PESO + COTIZACION_DOLAR);
            Console.WriteLine("Precio en Pesos: " + SIGNO_PESO + precioConvertidoARS);



            // Ejemplo 4

            const decimal COSTO_POR_KILO = 2500.50m;
            const decimal PESO_MAXIMO_PERMITIDO = 25.0m;

            decimal pesoGabinete = 8.5m;
            bool envioPermitido = pesoGabinete <= PESO_MAXIMO_PERMITIDO;
            decimal costoEnvioTotal = pesoGabinete * COSTO_POR_KILO;

            Console.WriteLine("\n4. LOGÍSTICA Y ENVÍOS");
            Console.WriteLine("Peso del bulto: " + pesoGabinete + "kg");
            Console.WriteLine("¿El peso está permitido?: " + envioPermitido);
            Console.WriteLine("Costo de envío: " + SIGNO_PESO + costoEnvioTotal);



            // Ejemplo 5

            const decimal DESCUENTO_COMBO_FIJO = 15000.00m;
            const bool INCLUYE_ARMADO_GRATIS = true;

            decimal precioMotherboard = 120000.00m;
            decimal precioRAM = 60000.00m;
            decimal subtotalComponentes = precioMotherboard + precioRAM;
            decimal totalCombo = subtotalComponentes - DESCUENTO_COMBO_FIJO;

            Console.WriteLine("\n5. PROMO COMBO ACTUALIZACIÓN");
            Console.WriteLine("Subtotal (Mother + RAM): " + SIGNO_PESO + subtotalComponentes);
            Console.WriteLine("Descuento aplicado: -" + SIGNO_PESO + DESCUENTO_COMBO_FIJO);
            Console.WriteLine("Total final: " + SIGNO_PESO + totalCombo);
            Console.WriteLine("¿Incluye armado gratis?: " + INCLUYE_ARMADO_GRATIS);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}
