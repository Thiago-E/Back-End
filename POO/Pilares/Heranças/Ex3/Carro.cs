namespace Heranca
{
    public class Carro : Veículos
    {

        public int QtdPortas;
        
        public override void MostrarInfo()
        {
            System.Console.WriteLine($"Marca: {Marca}");
            System.Console.WriteLine($"Modelo: {Modelo}");
            System.Console.WriteLine($"Quantidade de portas: {QtdPortas}");
        } 
    }
}