using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9Carro.Modelos
{
    internal class Carro
    {

        public string Modelo { get; set; } 
        public int Ano { get; set; }
        public double Valor { get; set; }

        public Carro() { }  


        public double CalcularDesconto()
        {
            if (Ano >= 2010)
            {
                return Valor * 0.05;

            }
            else
            {
                return Valor * 0.10;
            }
        }

        public void ExibeDados()
        {
            Console.WriteLine($"O valor do desconto para o modelo {Modelo}, ano {Ano} será de: {CalcularDesconto().ToString("F2")}.");
        }
    }
}
