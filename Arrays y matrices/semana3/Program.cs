using System;
namespace RegistrodeEstudiante
{
    class Estudiante
    {
        public int ID;
        public string Nombres;
        public string Apellidos;
        public string Direccion;
        public string[] Telefonos; // Para almacenar 3 números usamos Arrays

        public void MostrarDatos()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("Teléfonos:");
            foreach (string tel in Telefonos)
            {
                Console.WriteLine("- " + tel);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();

            Console.Write("Ingrese ID: ");
            estudiante.ID = int.Parse(Console.ReadLine());

            Console.Write("Ingrese Nombres: ");
            estudiante.Nombres = Console.ReadLine();

            Console.Write("Ingrese Apellidos: ");
            estudiante.Apellidos = Console.ReadLine();

            Console.Write("Ingrese Dirección: ");
            estudiante.Direccion = Console.ReadLine();

            estudiante.Telefonos = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ingrese teléfono {i + 1}: ");
                estudiante.Telefonos[i] = Console.ReadLine();
            }

            Console.WriteLine("\n--- Datos del Estudiante Registrado ---");
            estudiante.MostrarDatos();
        }
    }
}
