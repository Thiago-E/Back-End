// See https://aka.ms/new-console-template for more information

using Encapsulamento;

// float dinheiro = 200;

// ContaBancaria contaEdu = new ContaBancaria();
// ContaBancaria contaMaria = new ContaBancaria(dinheiro);

// contaEdu.Depositar(dinheiro);

// System.Console.WriteLine($"Novo saldo da conta R$ {contaEdu.GetSaldo()}");
// System.Console.WriteLine($"Saldo da Maria: R$ {contaMaria.GetSaldo}");

// contaEdu.Sacar(100);
// System.Console.WriteLine($"Saldo apos saque do Edu: R$ {contaEdu.GetSaldo}");

Carro C1 = new Carro();

C1.DefinirMarca("Nissan");
C1.DefinirModelo("GT-R");
C1.DefinirVelocidade(360);

C1.ObterVelocidade();

C1.Acelerar(12);

C1.ObterVelocidade();

C1.Freiar(72);

C1.ObterVelocidade();