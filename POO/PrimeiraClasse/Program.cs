//imports das classes externas
// using PrimeiraClasse;

// string nome = "Eduardo Costa";

// //cria um objetp do tipo
// Hello cumprimento = new Hello();

// cumprimento.TextoHello = "Olá usuário";

// cumprimento.SaldarUsuario();
// cumprimento.SaldarComNome("Eduardo Mendes");

using System.Security.Cryptography;
using PrimeiraClasse;

Carro c1 = new Carro();
c1.marca = "Lamborghini";
c1.modelo = "Urus";
c1.qtdPortas = 4;
c1.qtdRodas = 4;
c1.Ligar();
c1.Acelerar();
c1.Frear();
c1.Desligar();

Carro c2 = new Carro();
c2.marca = "Chevrolet";
c2.modelo = "Camaro";
c2.cor = "Amarelo";
c2.qtdPortas = 2;
c2.qtdRodas = 4;

Moto m1 = new Moto();
m1.marca = "Kawasaki";
m1.modelo = "Ninja";
m1.cor = "Verde";
m1.qtdRodas = 2;

Moto m2 = new Moto();
m1.marca = "Honda";
m1.modelo = "X-ADV";
m1.cor = "Amarelo";
m1.qtdRodas = 2;

Garrafa g1 = new Garrafa();
g1.marca = "TupperWare";
g1.cor = "Azul";
g1.qtdLitros = 1.5;


System.Console.WriteLine($"Ligando o {c2.modelo}");
System.Console.WriteLine($"Acelerando o {c2.modelo}");
System.Console.WriteLine($"Freando o {c2.modelo}");
System.Console.WriteLine($"Desligando o {c2.modelo}");

System.Console.WriteLine();
System.Console.WriteLine($"Características");
System.Console.WriteLine();

System.Console.WriteLine($"----- {c1.marca} -----");

System.Console.WriteLine($"Carro: {c1.marca}");
System.Console.WriteLine($"Modelo: {c1.modelo}");
System.Console.WriteLine($"Cor: {c1.cor}");
System.Console.WriteLine($"Quantidade de Portas: {c1.qtdPortas}");
System.Console.WriteLine($"Quantidade de Rodas: {c1.qtdRodas}");
System.Console.WriteLine();
System.Console.WriteLine("------");
System.Console.WriteLine();

System.Console.WriteLine($"----- {c2.marca} -----");
System.Console.WriteLine($"Carro: {c2.marca}");
System.Console.WriteLine($"Modelo: {c2.modelo}");
System.Console.WriteLine($"Cor: {c2.cor}");
System.Console.WriteLine($"Quantidade de Portas: {c2.qtdPortas}");
System.Console.WriteLine($"Quantidade de Rodas: {c2.qtdRodas}");
System.Console.WriteLine();

System.Console.WriteLine($"----- {m1.marca} -----");
System.Console.WriteLine($"Moto: {m1.marca}");
System.Console.WriteLine($"Modelo: {m1.modelo}");
System.Console.WriteLine($"Cor: {m1.cor}");
System.Console.WriteLine($"Quantidade de Rodas: {m1.qtdRodas}");
System.Console.WriteLine();

System.Console.WriteLine($"----- {m2.marca} -----");
System.Console.WriteLine($"Moto: {m2.marca}");
System.Console.WriteLine($"Modelo: {m2.modelo}");
System.Console.WriteLine($"Cor: {m2.cor}");
System.Console.WriteLine($"Quantidade de Rodas: {m2.qtdRodas}");
System.Console.WriteLine();



System.Console.WriteLine($"Marca: {g1.marca}");
System.Console.WriteLine($"Cor: {g1.cor}");
System.Console.WriteLine($"Quantidade de Litros: {g1.qtdLitros}");
System.Console.WriteLine();

