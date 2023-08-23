using Ex7Retangulo.Modelos;

namespace Ex7Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            retangulo.Altura = 2.5;
            retangulo.Base = 5;

            retangulo.ExibeDados();

        }
    }
}