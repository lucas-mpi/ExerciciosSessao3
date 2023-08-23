using Ex5MaiorIdade.Modelos;

namespace Ex5MaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();


            Console.Write("Informe o nome da pessoa: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Informe a idade de {0}: ", pessoa.Nome);
            pessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            pessoa.MostraDados();

            


        }
    }
}