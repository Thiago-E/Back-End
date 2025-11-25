// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using ClassesEstaticas;

Console.Clear();

// System.Console.WriteLine("Bem vindo ao programa");
// System.Console.WriteLine();

// System.Console.WriteLine($"Digite um número: ");
// float a = float.Parse(Console.ReadLine());

// System.Console.WriteLine($"Digite outro número: ");
// float b = float.Parse(Console.ReadLine());

// //uso da calsse est[atica de forma auxiliar
// float r = CalculosMatematicos.Somar(a, b);
// System.Console.WriteLine($"Soma: {r}");

// r = CalculosMatematicos.Subtrair(a, b);
// System.Console.WriteLine($"Subtração: {r}");

// r = CalculosMatematicos.Multiplicar(a, b);
// System.Console.WriteLine($"Multiplicação: {r}");

// r = CalculosMatematicos.Dividir(a, b);
// System.Console.WriteLine($"Divisão: {r}");

// System.Console.WriteLine($"Valor do PI é {Math.PI}");
// System.Console.WriteLine($"poência de 3 elevado a  2 é {Math.Pow(3, 2)}");

//Solicitar ao usuario 2 numero reais e informar quale é o maior e qual é o menor do numeros. Para isso voce deve utilizar a classe Math, Utilitaria do C#

System.Console.Write($"Digite um numero: ");
float a = float.Parse(Console.ReadLine());
System.Console.Write($"Digite outro numero: ");
float b = float.Parse(Console.ReadLine());

if (a == b)
{
    System.Console.WriteLine($"Os dois numeros são iguais");
}

else
{
    

System.Console.WriteLine($"O maior numero é: {Math.Max(a,b)}");
System.Console.WriteLine($"O menor numero é: {Math.Min(a,b)}");

}
