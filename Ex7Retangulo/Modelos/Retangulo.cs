using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7Retangulo.Modelos
{
    internal class Retangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Retangulo() { }


        public double CalculaPerimetro()
        {
            return (Base + Altura)*2;
        }

        public void ExibeDados()
        {
            Console.WriteLine($"O perímetro do retangulo é: {CalculaPerimetro()}");
        }
    }
}
