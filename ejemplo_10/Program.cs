using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double montoConsumo, descuento, impuesto, subtotal, total;

            // Solicitar al usuario que ingrese el monto del consumo
            Console.Write("Ingrese el monto del consumo: ");
            montoConsumo = double.Parse(Console.ReadLine());

            // Calcular el descuento y el impuesto
            if (montoConsumo <= 100.00)
            {
                descuento = montoConsumo * 0.10;
            }
            else
            {
                descuento = montoConsumo * 0.20;
            }

            impuesto = (montoConsumo - descuento) * 0.18;

            // Calcular el subtotal y el total
            subtotal = montoConsumo - descuento;
            total = subtotal + impuesto;

            // Mostrar los resultados
            Console.WriteLine($"Monto del descuento: {descuento:C}");
            Console.WriteLine($"Impuesto: {impuesto:C}");
            Console.WriteLine($"Subtotal: {subtotal:C}");
            Console.WriteLine($"Importe a pagar: {total:C}");

            // Esperar a que el usuario presione una tecla antes de cerrar
            Console.ReadKey();
        }
    }
}
