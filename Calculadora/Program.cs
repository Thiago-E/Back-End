double numero1 = 0;
double numero2 = 0;
double r = 0;
int escolhaDeOperacao;
string continuar;

do
{
    Console.WriteLine("===== CALCULADORA =====");
    Console.WriteLine("Escolha uma das operações:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("=======================");

    Console.Write("Digite o número da operação desejada: ");
    escolhaDeOperacao = int.Parse(Console.ReadLine());

    Console.Write("Digite o primeiro número: ");
    numero1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    numero2 = double.Parse(Console.ReadLine());

    switch (escolhaDeOperacao)
    {
        case 1:
            r = numero1 + numero2;
            Console.WriteLine($"Resultado: {r}");
            break;

        case 2:
            r = numero1 - numero2;
            Console.WriteLine($"Resultado: {r}");
            break;

        case 3:
            r = numero1 * numero2;
            Console.WriteLine($"Resultado: {r}");
            break;

        case 4:
            if (numero2 != 0)
            {
                r = numero1 / numero2;
                Console.WriteLine($"Resultado: {r}");
            }
            else
            {
                Console.WriteLine("Erro: Divisão por zero.");
            }
            break;

        default:
            Console.WriteLine("Operação inválida.");
            break;
    }

    Console.WriteLine("Deseja realizar outra operação? (S/N)");
    continuar = Console.ReadLine();

} while (continuar == "S");