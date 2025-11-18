namespace Heranca
{
    public class Gerente : Funcionarios
    {
        public int Bonus = 10;
        public double SalarioBase = 1100;

        public double CalcularSalario()
        {
            double SalarioFinal = SalarioBase * ((Bonus / 100) + 1);
            SalarioFinal = SalarioBase;
            return SalarioFinal;
        }
    }
}