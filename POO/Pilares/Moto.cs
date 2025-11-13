namespace Heranca
{
    public class Moto : Veículos
    {
        public string Capacete = "";

        public override void MostrarInfo()
        {
            System.Console.WriteLine($"Marca: {Marca}");
            System.Console.WriteLine($"Modelo: {Modelo}");
            System.Console.WriteLine($"Tipo de Capacete:{Capacete}");
        } 
    }
}