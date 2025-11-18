namespace Heranca
{
    public class Conta
    {
        public int Numero;
        public double Saldo;


        public void Depositar(double n)
        {
            Saldo = Saldo + n;
        }
        public void Sacar( double n)
        {
            Saldo = Saldo - n;
        }
        
    }
}