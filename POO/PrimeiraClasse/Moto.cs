namespace PrimeiraClasse
{
    public class Moto
    {
        //propriedades
        public int qtdRodas;

        public string marca = "";

        public string modelo = "";

        public string cor = "";

        //metodos
        public void Acelerar()
        {
            System.Console.WriteLine($"Moto Acelerando");

        }

        public void Frear()
        {
            System.Console.WriteLine($"Moto Freando");
        }

        public void Ligar()
        {
            System.Console.WriteLine($"Moto Ligando");
        }

        public void Desligar()
        {
            System.Console.WriteLine($"Moto Desligando");
        }
    }
}