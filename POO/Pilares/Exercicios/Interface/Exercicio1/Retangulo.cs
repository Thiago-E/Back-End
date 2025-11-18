using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class Retangulo : IForma
    {
        public float Altura;

        public float Largura;

        public void CalcularArea()
        {
            System.Console.WriteLine($"A área do retangulo é {Altura * Largura  }");
        }
    }
}