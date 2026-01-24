using System;
using System.Collections.Generic;
class TorresDeHanoi
{
    static Stack<int> origen = new Stack<int>();
    static Stack<int> entremedio = new Stack<int>();
    static Stack<int> destino = new Stack<int>();
    static void Main()
{
    int discos = 3;

    for (int i = discos; i >= 1; i--)
    origen.Push(i);
    MostrarTorres();   // 
    ResolverHanoi(discos, origen, destino, entremedio);
}
    static void ResolverHanoi(int n, Stack<int> origen, Stack<int> destino, Stack<int> entremedio)
    {
        if (n == 1)
        {
            destino.Push(origen.Pop());
            MostrarTorres();
            return;
        }
        ResolverHanoi(n - 1, origen, entremedio, destino);
        destino.Push(origen.Pop());
        MostrarTorres();
        ResolverHanoi(n - 1, entremedio, destino, origen);
    }
    static void MostrarTorres()
    {
        Console.WriteLine("Origen: " + string.Join(", ", origen));
        Console.WriteLine("Entremedio: " + string.Join(", ", entremedio));
        Console.WriteLine("Destino: " + string.Join(", ", destino));
        Console.WriteLine("---------------------------");
    }
}