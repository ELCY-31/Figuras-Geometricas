using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio4_Precios
{
    class Program
    {
        static void Main()
        {
            List<double> precios = new List<double> { 10.5, 25.0, 30.75, 15.2 };
            double iva = 0.12;

            Console.WriteLine("Precios:");
            foreach (var p in precios)
                Console.WriteLine($"${p:F2} + IVA = ${p * (1 + iva):F2}");

            double total = precios.Sum(p => p * (1 + iva));
            Console.WriteLine($"\nTotal a pagar: ${total:F2}");
        }
    }
}