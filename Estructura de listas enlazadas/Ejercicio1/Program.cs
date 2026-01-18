using System;
class Nodo
{
    public int Dato;
    public Nodo Siguiente;
    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}
class ListaEnlazada
{
    private Nodo cabeza;
    public void InsertarFinal(int dato)
    {
        Nodo nuevo = new Nodo(dato);

        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }
    // EJERCICIO 1
    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = cabeza;
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }
    public void MostrarLista()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}
class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        lista.InsertarFinal(10);
        lista.InsertarFinal(20);
        lista.InsertarFinal(30);

        lista.MostrarLista();
        Console.WriteLine("Cantidad de elementos: " + lista.ContarElementos());

        Console.ReadKey();
    }
}
