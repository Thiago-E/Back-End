Console.Write("Digite a média do aluno: ");
double media = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a frequência do aluno (%): ");
double frequencia = Convert.ToDouble(Console.ReadLine());

// Verificação de aprovação
if (frequencia < 75)
{
    Console.WriteLine("Aluno reprovado por frequência.");
}

    if (media >= 7.0)
    {
        Console.WriteLine("Aluno aprovado.");
    }
    else
    
        if (media >= 3.0)
        {
            Console.WriteLine("Aluno em recuperação.");
        }
        else
        {
            Console.WriteLine("Aluno reprovado por nota.");
        }