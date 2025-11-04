

namespace ClassesEObjetos
{
    public class Pessoa
    {
        public string Nome = "";

        public int Idade = 0;
        public void Falar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome}");
        }

        //aqui, quem não treina envelhece mais de um ano por vezPe

        public int Envelhecer(int _anos)
        {
            if (_anos <= 0)
            {
                System.Console.WriteLine($"Idade tem que ser positiva!");
                return Idade;//para o codigo aqui, não lê abaoxp    
            }

            Idade += _anos;//atualiza a idade

            return Idade;
        }

    }
}