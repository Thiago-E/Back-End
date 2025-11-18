using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Gato : Animal
    {
        public override void Fazersom()
        {
            System.Console.WriteLine($"Miaw Miaw");
        }

        public override void Mover()
        {
            System.Console.WriteLine($"Plec Plec Plec");
        }
    }
}