using Ex6MediaAluno.Modelos;

namespace Ex6MediaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno();

            aluno.Nome = "Lucas";
            aluno.Nota1 = 10.0;
            aluno.Nota2 = 8.5;
            aluno.Nota3 = 7.0;

            aluno.MostraDados();

        }
    }
}