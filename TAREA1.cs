using System;

namespace FigurasGeometricas
{
    // Clase Círculo
    public class Circulo
    {
        // Propiedad encapsulada
        private double radio;

        // Constructor
        public Circulo(double radio)
        {
            this.radio = radio > 0 ? radio : throw new ArgumentException("El radio debe ser mayor que 0.");
        }

        // Método para calcular el área
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        // Método para calcular el perímetro (circunferencia)
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase Rectángulo
    public class Rectangulo
    {
        // Propiedades encapsuladas
        private double largo;
        private double ancho;

        // Constructor
        public Rectangulo(double largo, double ancho)
        {
            this.largo = largo > 0 ? largo : throw new ArgumentException("El largo debe ser mayor que 0.");
            this.ancho = ancho > 0 ? ancho : throw new ArgumentException("El ancho debe ser mayor que 0.");
        }

        // Método para calcular el área
        public double CalcularArea()
        {
            return largo * ancho;
        }

        // Método para calcular el perímetro
        public double CalcularPerimetro()
        {
            return 2 * (largo + ancho);
        }
    }

    // Clase principal para probar las figuras
    public class Program
    {
        public static void Main(string[] args)
        {
            // Crear un círculo con radio 5
            Circulo circulo = new Circulo(5);
            Console.WriteLine("Círculo:");
            Console.WriteLine($"Área: {circulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro()}");

            // Crear un rectángulo con largo 10 y ancho 4
            Rectangulo rectangulo = new Rectangulo(10, 4);
            Console.WriteLine("\nRectángulo:");
            Console.WriteLine($"Área: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {rectangulo.CalcularPerimetro()}");
        }
    }
}
