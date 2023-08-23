using Ex1ClassePessoa.Modelos;
using System.Globalization;

namespace Ex1ClassePessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome da pessoa: ");

            string nome = Console.ReadLine();

            Console.Write("Informe a idade de {0}: ", nome);
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Informe a altura de {0}: ", nome);
            float altura = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Pessoa pessoa = new Pessoa(nome, idade, altura);
            Console.WriteLine();
            Console.WriteLine("Dados Informados: ");
            pessoa.ExibirDados();

        }
    }
}