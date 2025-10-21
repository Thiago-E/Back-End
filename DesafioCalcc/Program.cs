// See https://aka.ms/new-console-template for more information
int = n1, n2;

Console.WriteLine("Digite o primeiro número");
n1 = int.Parse( Console.Readline());
Console.WriteLine("Digite o segundo número") 
n2 = int.Parse( Console.Readline());

if ( n1 > n2)
{
  Console.WriteLine($"O Primeiro Numero e o maior: {n1}")
}
else {
  Console.WriteLine($"O Segundo Numero e o maior: {n2}")
}

//somar os dois números
int soma = numero1 + numero2;

//exibir nome e a soma
Console.WriteLine(nome); // exibe o nome do usuário
Console.WriteLine(soma);

if (n1 > n2) {
  Console.WriteLine("Primeiro numero é maior" + n1); //interpola o valor da variavel n1
}

else if(n1 < n2){
   Console.WriteLine($"O segundo numero é o maior {n2}");
}

else{
  Console.WriteLine($"Os numeros {n1} e {n2} são iguais");
}