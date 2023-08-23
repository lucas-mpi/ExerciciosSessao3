using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8Funcionario.Modelos
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioHora { get; set; }

        public double CargaHoraria { get; set; }

        public Funcionario() { }

        public double SalarioTotal()
        {
            return SalarioHora * CargaHoraria;

        }

        public void ExibeDados()
        {
            Console.WriteLine($"O salário de {Nome} ficou em R$ {SalarioTotal()}.");
        }
    }
}
