﻿using Heranca;

//                              Animal
// Gato g1 = new Gato();
// g1.FazerSom();
// Cachorro c1 = new Cachorro();
// c1.FazerSom();


// //                           Funcionários 
// Funcionarios f1 = new Funcionarios();
// System.Console.WriteLine($"Salario do funcionario: {f1.SalarioBase}");
// Gerente g1 = new Gerente();
// System.Console.WriteLine($"Salario do gerente: {g1.SalarioBase}");


// //                              Veículos 
// Moto m1 = new Moto();
// System.Console.WriteLine($"Moto");
// m1.Marca = "Yamaha";
// m1.Modelo = "X-17";
// m1.Capacete = "M74";
// m1.MostrarInfo();
// Carro c1 = new Carro();
// System.Console.WriteLine($"Carro");
// c1.Marca = "Volvo";
// c1.Modelo = "Uno";
// c1.QtdPortas = 2;
// c1.MostrarInfo();


// //                              Escola 
// Aluno a1 = new Aluno();
// a1.Nome = "Carlos";
// a1.Curso = "Desenvolvimento de sistema";
// a1.Idade = 17;

// Professor p1 = new Professor();
// p1.Nome = "Cleber";
// p1.Disciplina = "Desenvolvimento de sistema";
// p1.Idade = 71;

// System.Console.WriteLine($"---------------Professor-------------");
// System.Console.WriteLine(@$"Nome: {p1.Nome}
//                             Idade: {p1.Idade}
//                             Disiplina: {p1.Disciplina}");

// System.Console.WriteLine($"---------------Aluno-------------");
// System.Console.WriteLine(@$"Nome: {a1.Nome}
// Idade: {a1.Idade}
// Curso: {a1.Curso}");


//                              Sistema bancário 
ContaPoupanca c1 = new ContaPoupanca();
c1.Saldo = 2000;
c1.Depositar(1400);
c1.Sacar(200);
c1.CalcularRendimento(); 
System.Console.WriteLine(@$"Saldo Inicaial: {c1.Saldo}
Saldo Final: {c1.SaldoF}");