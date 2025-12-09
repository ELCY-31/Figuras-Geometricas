using System;
namespace FigurasGeometricas
{
    public class Circulo
    {
        // Campo privado que almacena el radio del círculo
        private double radio;

        // Constructor que recibe el radio como parámetro
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método para calcular el área del círculo: π * r²
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Método para calcular el perímetro (circunferencia): 2 * π * r
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    public class Cuadrado
    {
        // Campo privado que almacena el lado del cuadrado
        private double lado;

        // Constructor que recibe el lado como parámetro
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        // Método para calcular el área del cuadrado: lado²
        public double CalcularArea()
        {
            return lado * lado;
        }

        // Método para calcular el perímetro: 4 * lado
        public double CalcularPerimetro()
        {
            return 4 * lado;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso
            Circulo miCirculo = new Circulo(5);
            Console.WriteLine("Área del círculo: " + miCirculo.CalcularArea());
            Console.WriteLine("Perímetro del círculo: " + miCirculo.CalcularPerimetro());

            Cuadrado miCuadrado = new Cuadrado(4);
            Console.WriteLine("Área del cuadrado: " + miCuadrado.CalcularArea());
            Console.WriteLine("Perímetro del cuadrado: " + miCuadrado.CalcularPerimetro());
        }
    }
}