using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex3Triangulo.Modelos
{
    internal class Triangulo
    {
        public double Base { get; set; }

        public double Altura { get; set; }

        public Triangulo(double valorBase, double valorAltura) {
            
            Base = valorBase;
            Altura = valorAltura;
        
        }

        public double CalcularArea()
        {
            return (Base * Altura)/2;

        }


    }
}
