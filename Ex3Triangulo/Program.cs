using Ex3Triangulo.Modelos;
using System.Globalization;

namespace Ex3Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo novoTriangulo = new Triangulo(10, 2.5);

            double resultado = novoTriangulo.CalcularArea();

            Console.Write("A área do triangulo é: {0}", resultado);
            Console.WriteLine();

        }
    }
}