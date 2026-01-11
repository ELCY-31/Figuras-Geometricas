using System;
using System.Collections.Generic;

namespace Ejercicio1_Asignaturas
{
    class Curso
    {
        private List<string> asignaturas = new List<string>
        {
            "Matemáticas", "Física", "Química", "Historia", "Lengua"
        };

        public void MostrarAsignaturas()
        {
            Console.WriteLine("Asignaturas del curso:");
            foreach (var a in asignaturas)
                Console.WriteLine($"- {a}");
        }
    }

    class Program
    {
        static void Main()
        {
            Curso curso = new Curso();
            curso.MostrarAsignaturas();
        }
    }
}