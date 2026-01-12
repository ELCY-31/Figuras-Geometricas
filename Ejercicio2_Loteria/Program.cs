using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio2_Loteria
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            HashSet<int> numeros = new HashSet<int>();

            while (numeros.Count < 6)
                numeros.Add(rand.Next(1, 50));

            Console.WriteLine("Números de lotería:");
            Console.WriteLine(string.Join(", ", numeros.OrderBy(n => n)));
        }
    }
}