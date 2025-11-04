namespace MetodoConstrutor
{
    public class Pessoa3SobreCarga
    {
        public string Nome = "";
        public int Idade;

        public Pessoa3SobreCarga() //Não tem sobrecarga
        {
            Nome = "Desconhecido";
            Idade = 0;
        }
        
        public Pessoa3SobreCarga(string n) //Sobrecarrega a idade pois iguala a algo que ele acabou de criar
        {
            Nome = n;
            Idade = 0;
        }
        public Pessoa3SobreCarga(string n, int i) //Sobrecarrega o Nome e idade pois iguala a algo pré determinado
        {
            Nome = n; //Inicaliza o valor de n
            Idade = i; //Inicaliza o valor de i
        }

        public void ExibirDados() //   O "()" são os parametros
        {
            Console.WriteLine($"Nome: {Nome} Idade:{Idade}");
        }
    }
}
