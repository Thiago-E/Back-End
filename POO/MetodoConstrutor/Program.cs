using MetodoConstrutor;

// Pessoa Fontes = new Pessoa("Felipe" , 17);

// // Lucas.Nome = "Lucas Marinho";
// // Lucas.Idade = 17;

// System.Console.WriteLine(@$"O objeto pessoa que criei é o {Fontes.Nome} com a idade
// {Fontes.Nome}");

// // Fontes.Nome = "Felipe Gonçalves";

// // Fontes.Nome = "Henrique";
// Fontes.ExibirDados();

// System.Console.WriteLine($"{Fontes.Nome}");

//-------------------------------------------------------------------------------------------------//

//3 Pessoas Sobre Carga

// Primeiro metodo construtor da class Pessoa3SobreCarva
Pessoa3SobreCarga PrimeiraPessoa = new Pessoa3SobreCarga();
System.Console.WriteLine("Qual o seu nome?");
PrimeiraPessoa.Nome = Console.ReadLine();
System.Console.WriteLine("Qual a sua idade?");
PrimeiraPessoa.Idade = int.Parse(Console.ReadLine());

System.Console.WriteLine(@$"Primeira pessoa cadastrada
                            Nome :{PrimeiraPessoa.Nome}
                            Idade :{PrimeiraPessoa.Idade}");

// Segunda metodo construtor da class Pessoa3SobreCarva
Pessoa3SobreCarga SegundaPessoa = new Pessoa3SobreCarga("Matheus Felix");
System.Console.WriteLine(@$"Segunda pessoa cadastrada
                            Nome :{SegundaPessoa.Nome}
                            Idade :{SegundaPessoa.Idade}");

// Terceira metodo construtor da class Pessoa3SobreCarva
Pessoa3SobreCarga TerceiraPessoa = new Pessoa3SobreCarga("Bruno");
   System.Console.WriteLine("Digite o nome do usário");
TerceiraPessoa.Nome = Console.ReadLine();
    System.Console.WriteLine("Digite a idade do usuário");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());
System.Console.WriteLine(@$"Terceira pessoa cadastrada  
                            Nome :{TerceiraPessoa.Nome}
                            Idade :{TerceiraPessoa.Idade}");