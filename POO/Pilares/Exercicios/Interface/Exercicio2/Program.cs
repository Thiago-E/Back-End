using Exercicio2;


List<IImprimivel> imprimidos = new List<IImprimivel>();
List<Contrato> contratos = new List<Contrato>();
List<Fatura> faturas = new List<Fatura>();
List<Relatorio> documentos = new List<Relatorio>();


//MENU

int opção = -1;

do{
System.Console.WriteLine($"Menu de opções");
System.Console.WriteLine($@"
-------------------------------------
1 - Cadastrar Fatura
2 - Cadastrar Relatório
3 - Cadastrar Contrato
4 - Listar Faturas
5 - Listar Relatórios
6 - Listar Contratos
0 - Sair
-------------------------------------

opção = int.Parse(Console.ReadLine());
");

switch (opção)
{
    case 1:
        Console.WriteLine("Cadastrar Fatura");
        break;
    case 2:
        Console.WriteLine("Cadastrar Fatura");
        break;
    case 3:
        Console.WriteLine("Cadastrar Fatura");
        break;
    case 4:
        Console.WriteLine("Cadastrar Fatura");
        break;
    case 5:
        Console.WriteLine("Cadastrar Fatura");
        break;
    case 6:
        Console.WriteLine("Cadastrar Fatura");
        break;
    case 0:
        Console.WriteLine("Saindo");
        opção = 0;
        break;
    default:
        Console.WriteLine("Opção invalida");
    break;
}


System.Console.WriteLine($"Digite <enter> para continuar");
Console.ReadLine();

} while(opção != 0);







//Funções auxiliares
void CadastrarFatura()
{
    Console.WriteLine($"Digite o nome do devedor");
    string dev = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine($"Digite o nome do credor");
    string cred = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine($"Digite o valor (R$)");
    double valor = double.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine($"Dias atrasados");
    int diasAtraso = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Fatura f = new Fatura(dev, cred, valor, diasAtraso);
}

void CadastrarContrato()
{
    Console.WriteLine($"Digite o nome do contratante");
    string contratante = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine($"Digite o nome do PrestadorServiso");
    string PrestadorServiso = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine($"Digite as  clausulas");
    string TextoClausulas = Console.ReadLine();
    Console.WriteLine();

    Contrato C = new Contrato(contratante, PrestadorServiso, TextoClausulas);
}


void CadastrarRelatorio()
{
    Console.WriteLine($"Digite o nome do autor do relatorio");
    string Nome = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine($"Digite o texto relatorio");
    string TextoRelatorio = Console.ReadLine();
    Console.WriteLine();

    Relatorio R = new Relatorio(Nome, TextoRelatorio);
}

void ListarFaturas()
{
    System.Console.WriteLine($"Listando as Faturas: ");
    foreach(var item in faturas)
    {
        if (item is Fatura)
        {
        item.Imprimir();
        }
    }

}

void ListarContratos()
{
    System.Console.WriteLine($"Listando os Contratos: ");
    foreach(var item in faturas)
    {
        if (item is Contrato)
        {
        item.Imprimir();
        }
    }

}

void ListarRelatorios()
{
    System.Console.WriteLine($"Listando os Relatorios: ");
    foreach(var item in faturas)
    {
        if (item is Relatorio)
        {
        item.Imprimir();
        }
    }

}
