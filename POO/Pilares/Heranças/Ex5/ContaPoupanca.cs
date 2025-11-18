namespace Heranca
{
    public class ContaPoupanca : Conta
    {
        public double SaldoF;
        public void CalcularRendimento()
        {
            SaldoF = Saldo * 1.02;
        }
    }
}