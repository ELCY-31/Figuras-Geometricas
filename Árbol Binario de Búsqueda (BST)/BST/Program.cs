#nullable disable
using System;
class Nodo
{
    public int Valor;
    public Nodo Izq, Der;
    public Nodo(int valor)
    {
        Valor = valor;
        Izq = Der = null;
    }
}
class Arbol
{
    public Nodo raiz;
    public Nodo Insertar(Nodo r, int valor)
    {
        if (r == null) return new Nodo(valor);
        if (valor < r.Valor)
            r.Izq = Insertar(r.Izq, valor);
        else
            r.Der = Insertar(r.Der, valor);
        return r;
    }
    public bool Buscar(Nodo r, int valor)
    {
        if (r == null) return false;
        if (r.Valor == valor) return true;
        return valor < r.Valor ? Buscar(r.Izq, valor) : Buscar(r.Der, valor);
    }
    public Nodo Eliminar(Nodo r, int valor)
    {
        if (r == null) return r;
        if (valor < r.Valor)
            r.Izq = Eliminar(r.Izq, valor);
        else if (valor > r.Valor)
            r.Der = Eliminar(r.Der, valor);
        else
        {
            if (r.Izq == null) return r.Der;
            if (r.Der == null) return r.Izq;
            Nodo min = r.Der;
            while (min.Izq != null) min = min.Izq;
            r.Valor = min.Valor;
            r.Der = Eliminar(r.Der, min.Valor);
        }
        return r;
    }
    public void InOrden(Nodo r)
    {
        if (r != null)
        {
            InOrden(r.Izq);
            Console.Write(r.Valor + " ");
            InOrden(r.Der);
        }
    }
    public void PreOrden(Nodo r)
    {
        if (r != null)
        {
            Console.Write(r.Valor + " ");
            PreOrden(r.Izq);
            PreOrden(r.Der);
        }
    }
    public void PostOrden(Nodo r)
    {
        if (r != null)
        {
            PostOrden(r.Izq);
            PostOrden(r.Der);
            Console.Write(r.Valor + " ");
        }
    }
    public int Min(Nodo r)
    {
        while (r.Izq != null) r = r.Izq;
        return r.Valor;
    }
    public int Max(Nodo r)
    {
        while (r.Der != null) r = r.Der;
        return r.Valor;
    }
    public int Altura(Nodo r)
    {
        if (r == null) return -1;
        return Math.Max(Altura(r.Izq), Altura(r.Der)) + 1;
    }
}
class Program
{
    static void Main()
    {
        Arbol t = new Arbol();
        int op, v;
        do
        {
            Console.WriteLine("\n1.Insertar 2.Buscar 3.Eliminar 4.Recorridos 5.Datos 6.Limpiar 0.Salir");
            if (!int.TryParse(Console.ReadLine(), out op))
            {
                Console.WriteLine("Ingrese un número válido");
                continue;
            }
            switch (op)
            {
                case 1:
                    Console.Write("Valor: ");
                    if (int.TryParse(Console.ReadLine(), out v))
                        t.raiz = t.Insertar(t.raiz, v);
                    break;
                case 2:
                    Console.Write("Buscar: ");
                    if (int.TryParse(Console.ReadLine(), out v))
                        Console.WriteLine(t.Buscar(t.raiz, v) ? "Existe" : "No existe");
                    break;
                case 3:
                    Console.Write("Eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out v))
                        t.raiz = t.Eliminar(t.raiz, v);
                    break;
                case 4:
                    Console.Write("InOrden: "); t.InOrden(t.raiz);
                    Console.Write("\nPreOrden: "); t.PreOrden(t.raiz);
                    Console.Write("\nPostOrden: "); t.PostOrden(t.raiz);
                    Console.WriteLine();
                    break;
                case 5:
                    if (t.raiz != null)
                    {
                        Console.WriteLine("Min: " + t.Min(t.raiz));
                        Console.WriteLine("Max: " + t.Max(t.raiz));
                        Console.WriteLine("Altura: " + t.Altura(t.raiz));
                    }
                    else
                        Console.WriteLine("Árbol vacío");
                    break;
                case 6:
                    t.raiz = null;
                    Console.WriteLine("Árbol limpio");
                    break;
            }
        } while (op != 0);
    }
}