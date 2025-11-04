using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome;

        public int Idade;

        //metodo construtor de Pessoa, possuindo parametros
        /*Parametros representam os valores para as suas respectivas propriedades de nome e idade ou seja, estamos inicializando valores para as propriedades nome e idade*/

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}