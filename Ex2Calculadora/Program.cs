using Ex2Calculadora.Modelos;
using System.Globalization;

namespace Ex2Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculadora operacao = new Calculadora();

            char continuar = 's';
            do
            {
                Console.Write("Informe o primeiro valor: ");
                float num1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Informe o segundo valor: ");
                float num2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                Console.Write("Qual operação deseja realizar: Soma, Subtração, Divisão ou Multiplicação?");
                string metodo = Console.ReadLine().ToLower();
                switch (metodo)
                {
                    case "soma":
                        operacao.Soma(num1, num2);
                        break;

                    case "subtracao":
                        operacao.Subtrai(num1, num2);
                        break;

                    case "divisao":
                        operacao.Divide(num1, num2);
                        break;

                    case "multiplicacao":
                        operacao.Multiplica(num1, num2);
                        break;
                }

                operacao.ExibeResultado();
                Console.WriteLine();

                Console.Write("Deseja continuar? (S/N): ");
                continuar = char.Parse(Console.ReadLine().ToLower());
                Console.WriteLine()
                Console.WriteLine();


            } while (continuar == 's');

        }
    }
}