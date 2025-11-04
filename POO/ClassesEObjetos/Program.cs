using ClassesEObjetos;

Pessoa joao = new Pessoa();

joao.Nome = "João Silva";

System.Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

joao.Envelhecer(17);

System.Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

joao.Envelhecer(-50);

System.Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

//----------------------------------------------------------------------------



ContaBancaria cb1 = new ContaBancaria();
System.Console.WriteLine("cadastre o titular da conta");
cb1.titular = Console.ReadLine();

System.Console.WriteLine("Diga o saldo do titular");
cb1.saldo = double.Parse(Console.ReadLine());

System.Console.WriteLine("Agora escolha uma das opções:");
System.Console.WriteLine("  1. Depositar");
System.Console.WriteLine("  2. Sacar");

int opcao = int.Parse(Console.ReadLine());

System.Console.WriteLine();

switch (opcao)
{
    case 1: cb1.Depositar();
        break;

    case 2: cb1.Sacar();
        break;

    default: System.Console.WriteLine("Opção Inválida!");
        break;
}

System.Console.WriteLine($"o saldo atualizado é: {cb1.saldo:F2}");
