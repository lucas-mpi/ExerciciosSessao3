using Ex8Funcionario.Modelos;

namespace Ex8Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Nome = "Lucas";
            funcionario.SalarioHora = 11.50;
            funcionario.CargaHoraria = 200;


            funcionario.ExibeDados();
        }
    }
}