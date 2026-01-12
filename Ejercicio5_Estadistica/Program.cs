using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio5_Estadistica
{
    class Program
    {
        static void Main()
        {
            List<double> muestra = new List<double> { 8, 6, 7, 5, 9, 10 };

            double media = muestra.Average();
            double sumaCuadrados = muestra.Sum(x => Math.Pow(x - media, 2));
            double desviacion = Math.Sqrt(sumaCuadrados / muestra.Count);

            Console.WriteLine($"Media: {media:F2}");
            Console.WriteLine($"Desviación típica: {desviacion:F2}");
        }
    }
}