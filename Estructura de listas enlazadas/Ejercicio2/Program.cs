using System;
class Vehiculo
{
    public string Placa;
    public string Marca;
    public string Modelo;
    public int Anio;
    public double Precio;
    public Vehiculo Siguiente;
    public Vehiculo(string placa, string marca, string modelo, int anio, double precio)
    {
        Placa = placa;
        Marca = marca;
        Modelo = modelo;
        Anio = anio;
        Precio = precio;
        Siguiente = null;
    }
}
class ListaVehiculos
{
    private Vehiculo cabeza;
    public void AgregarVehiculo(string placa, string marca, string modelo, int anio, double precio)
    {
        Vehiculo nuevo = new Vehiculo(placa, marca, modelo, anio, precio);

        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Vehiculo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }
    public void BuscarPorPlaca(string placa)
    {
        Vehiculo actual = cabeza;
        while (actual != null)
        {
            if (actual.Placa == placa)
            {
                Console.WriteLine($"Vehículo encontrado: {actual.Marca} {actual.Modelo}");
                return;
            }
            actual = actual.Siguiente;
        }
        Console.WriteLine("Vehículo no encontrado.");
    }
    public void VerPorAnio(int anio)
    {
        Vehiculo actual = cabeza;
        bool encontrado = false;

        while (actual != null)
        {
            if (actual.Anio == anio)
            {
                Console.WriteLine($"{actual.Placa} - {actual.Marca} {actual.Modelo}");
                encontrado = true;
            }
            actual = actual.Siguiente;
        }
        if (!encontrado)
            Console.WriteLine("No hay vehículos de ese año.");
    }
    public void MostrarTodos()
    {
        Vehiculo actual = cabeza;
        while (actual != null)
        {
            Console.WriteLine($"{actual.Placa} | {actual.Marca} | {actual.Modelo} | {actual.Anio} | ${actual.Precio}");
            actual = actual.Siguiente;
        }
    }
    public void EliminarVehiculo(string placa)
    {
        if (cabeza == null) return;

        if (cabeza.Placa == placa)
        {
            cabeza = cabeza.Siguiente;
            Console.WriteLine("Vehículo eliminado.");
            return;
        }
        Vehiculo actual = cabeza;
        while (actual.Siguiente != null && actual.Siguiente.Placa != placa)
        {
            actual = actual.Siguiente;
        }

        if (actual.Siguiente != null)
        {
            actual.Siguiente = actual.Siguiente.Siguiente;
            Console.WriteLine("Vehículo eliminado.");
        }
        else
        {
            Console.WriteLine("Vehículo no encontrado.");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        ListaVehiculos lista = new ListaVehiculos();

        lista.AgregarVehiculo("ABC123", "Toyota", "Corolla", 2020, 15000);
        lista.AgregarVehiculo("XYZ789", "Chevrolet", "Spark", 2019, 9000);

        lista.MostrarTodos();
        lista.BuscarPorPlaca("ABC123");
        lista.VerPorAnio(2019);
        lista.EliminarVehiculo("XYZ789");

        Console.ReadKey();
    }
}
