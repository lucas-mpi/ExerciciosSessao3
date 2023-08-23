using Ex9Carro.Modelos;

namespace Ex9Carro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            carro.Modelo = "Marea Turbo 2.5 20v";

            carro.Ano = 2006;

            carro.Valor = 9000.00;

            carro.ExibeDados();
        }
    }
}