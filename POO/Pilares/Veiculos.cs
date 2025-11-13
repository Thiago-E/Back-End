namespace Heranca
{
    public class Veículos
    {
        public string Marca = "";
        public string Modelo = "";


        public virtual void MostrarInfo()
        {
            System.Console.WriteLine($"Marca: {Marca}");
            System.Console.WriteLine($"Modelo: {Modelo}");
        } 
    }
}