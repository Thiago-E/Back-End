/* pedir o nome do usuário,
Pedir dois números e 
mostrar a soma dos números no final*/

string nome;
int numero1;
int numero2;

//pedir os nome pro usuário
nome = Console.Readline(); // pede o nome do usuário
Console.WriteLine(nome);

//pedir os dois números
Console.WriteLine("Digite o primeiro numero");
numero1 =  int.Parse(Console.Readline);
Console.WriteLine("Digite o segundo numero");
numero1 =  int.Parse(Console.Readline);
// somar os dois números
int soma = numero1 + numero2;
//exibir  nome e a soma
Console.WriteLine(nome); //exibe o nomeu do usuário
Console.WriteLine(soma); //exibe o nome do usuário