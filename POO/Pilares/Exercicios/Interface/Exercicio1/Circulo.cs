using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class Circulo : IForma
    {
        public float raio;

        private float PI = 3.14f;

        public void CalcularArea()
        {
            System.Console.WriteLine($"O área do circulo é `{PI * raio * raio}");
        }
    }
}