using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Calculadora.Modelos
{
    internal class Calculadora
    {
        public float Resultado { get; set; }

        public Calculadora()
        {
            
        }

        public void Soma(float num1, float num2)
        {
            Resultado = num1 + num2;
        }

        public void Subtrai(float num1, float num2)
        {
            Resultado = num1 - num2;

        }

        public void Multiplica(float num1, float num2)
        {
            Resultado = num1 * num2;
        }

        public void Divide(float num1, float num2)
        {
            Resultado = num1 / num2;
        }

        public void ExibeResultado()
        {
            Console.WriteLine($"O resultado da operação é: {Resultado}");
        }


    }
}
