namespace PrimeiraClasse
{
   public  class Hello
    {
        //Propriedades/Características - variáveis internas dessa classe

        public string TextoHello = "";

        //Métodos/Comportamentos/Ações - são as funçõpes internas dessa classe

        public void SaldarUsuario()
        {
            System.Console.WriteLine(this.TextoHello);
        }

        public void SaldarComNome(string n )
        {
            System.Console.WriteLine($"Olá {n}");
        }
    }
}
