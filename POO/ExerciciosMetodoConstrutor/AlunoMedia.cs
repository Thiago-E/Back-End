using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class AlunoMedia
    {
        public string Nome;
        public double N1, N2, N3;

        public AlunoMedia(double param1, double param2, double param3)
        {
            //Define os valores iniciais para as minha propriedades
            //N1 = 0; //fixo
            N1 = param1; //parametro param1 representa o valor do N1 - valor dinamico
            N2 = param2; //parametro param1 representa o valor do N1 - valor dinamico
            N3 = param3; //parametro param1 representa o valor do N1 - valor dinamico
        }

        public AlunoMedia()
        {
            N1 = N2 = N3 = 0; //Atribuindo um valor fixo para as 3 propriedades de uma vez
        }
        
        public void Media()
        {
            double media = (N1 + N2 + N3) / 3;
            System.Console.WriteLine($"A Média do(a) {Nome} foi: {media}");
        }

        }
    }
