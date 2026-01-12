using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio3_Reprobadas
{
    class Program
    {
        static void Main()
        {
            List<int> notas = new List<int> { 70, 45, 90, 35, 30, 80, 60 };

            int reprobados = notas.Count(n => n < 60);

            Console.WriteLine("Notas: " + string.Join(", ", notas));
            Console.WriteLine($"Reprobados: {reprobados}");
        }
    }
}