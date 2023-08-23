using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5MaiorIdade.Modelos
{
    internal class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public Pessoa()
        {

        }

        public string VerificaIdade()
        {
            if (Idade >= 18)
            {
                return "é de maior.";

            }
            else
            {
                return  "é de menor.";
            }
        }

        public void MostraDados()
        {
            Console.WriteLine($"{Nome} {VerificaIdade()}.");
        }
       
    }
}
