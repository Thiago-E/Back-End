// Exercício 1 
/* Crie uma interface chama IForma com o método CalcularArea.
    Crie duas classes que implementem essa interface: Retangulo e Circulo.
    No programa, peça os valores necessários e exiba a área calculada para cada forma.

    No Retângulo utilizar o cálculo = Largura * Altura;
    No Círculo utilizar o cálculo = PI * RAIO * RAIO;

    Math.PI*/

//Retangulo
using Interface;

System.Console.WriteLine($"===== Bem vindo ao programa Cálculos de Geometria :) =====");
System.Console.WriteLine();

System.Console.WriteLine($"Vamos calcular o Retângulo ");

//Altura e Largura
System.Console.WriteLine($"Digite a largura:");
float l = float.Parse(Console.ReadLine());
System.Console.WriteLine($"Digite a altura: ");
float a = float.Parse(Console.ReadLine());

Retangulo ret = new Retangulo();
ret.Altura = a;
ret.Largura = l;
ret.CalcularArea();


//Circulo
System.Console.WriteLine();
System.Console.WriteLine($"Agora vamos calcular  a area do circulo");
System.Console.WriteLine($"Informe o raio do círculo: ");
float r = float.Parse(Console.ReadLine());

Circulo cir = new Circulo();
cir.raio = r;
cir.CalcularArea();

System.Console.WriteLine();
System.Console.WriteLine($"Fim do programa");
System.Console.WriteLine();