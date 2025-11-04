using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class ALuno
    {
        public string Nome;

        public double Nota;
         public ALuno()
        {
            Nome = "Desconhecido";
            Nota = 0;
        }

        public ALuno(string n, double nt)
        {
            Nome = n;
            Nota = nt;
        }

    }
    
   
   
    }
   
