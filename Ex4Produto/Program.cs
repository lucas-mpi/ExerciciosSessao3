using Ex4Produto.Modelos;

namespace Ex4Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("Televisão", 1050.90, 2);


            double valorTotal = produto.CalcularTotal();

            Console.Write("O valor total do produto é: {0}", valorTotal);
            Console.WriteLine();

        }
    }
}