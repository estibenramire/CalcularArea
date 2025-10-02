using CalcularArea.Formas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cálculo de Rectángulo");
            Rectangulo rectangulo = new Rectangulo(4, 6);
            Console.WriteLine($"El área del rectángulo es: {rectangulo.GetArea()}");

            Console.WriteLine("Cálculo de Cuadrado");
            Cuadrado cuadrado= new Cuadrado(5);
            Console.WriteLine($"El área del cuadrado es: {cuadrado.GetArea()}");

          

            Console.WriteLine("Cálculo de Rombo");
            Rombo rombo = new Rombo(4, 6);
            Console.WriteLine($"El área del rombo es: {rombo.CalcularArea()}");

            Console.WriteLine("Cálculo de Elipse");
            Elipse elipse = new Elipse(4, 6);
            Console.WriteLine($"El área de la elipse es: {elipse.GetArea()}");

            Console.WriteLine("Cálculo de Círculo");
            Circulo circulo = new Circulo(3);
            Console.WriteLine($"El área del círculo es: {circulo.GetArea()}");

            Console.WriteLine("Cálculo de Triángulo");
            Triangulo triangulo = new Triangulo(4, 6);
            Console.WriteLine($"El área del triángulo es: {triangulo.CalcularArea()}");


        }
    }
}
