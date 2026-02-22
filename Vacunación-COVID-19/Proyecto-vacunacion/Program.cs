using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        // Conjunto universal de 500 ciudadanos
        HashSet<string> ciudadanos = GenerarCiudadanos(500);

        // 75 vacunados con Pfizer
        HashSet<string> pfizer = GenerarSubconjunto(1, 75);

        // 75 vacunados con AstraZeneca
        HashSet<string> astra = GenerarSubconjunto(50, 124);

        // Operaciones de teoría de conjuntos
        var ambasDosis = pfizer.Intersect(astra).OrderBy(x => x).ToList();
        var soloPfizer = pfizer.Except(astra).OrderBy(x => x).ToList();
        var soloAstra = astra.Except(pfizer).OrderBy(x => x).ToList();
        var vacunados = pfizer.Union(astra);
        var noVacunados = ciudadanos.Except(vacunados).OrderBy(x => x).ToList();

        // Mostrar los resultados
        MostrarLista("NO VACUNADOS", noVacunados);
        MostrarLista("AMBAS DOSIS", ambasDosis);
        MostrarLista("SOLO PFIZER", soloPfizer);
        MostrarLista("SOLO ASTRAZENECA", soloAstra);

        Console.WriteLine("\n==== RESUMEN ====");
        Console.WriteLine("Total ciudadanos: " + ciudadanos.Count);
        Console.WriteLine("No vacunados: " + noVacunados.Count);
        Console.WriteLine("Ambas dosis: " + ambasDosis.Count);
        Console.WriteLine("Solo Pfizer: " + soloPfizer.Count);
        Console.WriteLine("Solo AstraZeneca: " + soloAstra.Count);
    }
    static HashSet<string> GenerarCiudadanos(int cantidad)
    {
        HashSet<string> lista = new HashSet<string>();

        for (int i = 1; i <= cantidad; i++)
        {
            lista.Add("Ciudadano " + i);
        }

        return lista;
    }
    static HashSet<string> GenerarSubconjunto(int inicio, int fin)
    {
        HashSet<string> subconjunto = new HashSet<string>();

        for (int i = inicio; i <= fin; i++)
        {
            subconjunto.Add("Ciudadano " + i);
        }

        return subconjunto;
    }
    static void MostrarLista(string titulo, List<string> lista)
    {
        Console.WriteLine("\n--- " + titulo + " ---");

        foreach (var ciudadano in lista)
        {
            Console.WriteLine(ciudadano);
        }
    }
}
