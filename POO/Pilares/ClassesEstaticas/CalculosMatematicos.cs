using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {   
        // Operações Matemáticas simples
        // visibilidade

    public static float Somar(float a, float b)
        {
            return a + b;
        }

        public static float Subtrair(float a, float b)
        {
            return a - b;
        }

        public static float Multiplicar(float a, float b)
        {
            return a * b;
        }

        public static float Dividir(float a, float b)
        {

            if( b != 0)
            {
            return a / b;
            }

            else
            {
                    System.Console.WriteLine($"Não é possivel dividir um número por zero");

                    return 0;
            }
        }

           public static void Maior( float a, float b)
        {
            System.Console.WriteLine($"{Math.Max(a,b)}");
        }
        
            
        
        
    }
}