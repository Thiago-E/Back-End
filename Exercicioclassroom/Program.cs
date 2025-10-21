double S,Total = 0;

Console.WriteLine("Qual o seu salario?: ");
S = double.Parse(Console.ReadLine());

Console.WriteLine("Qual o total gasto?: ");
Total = double.Parse(Console.ReadLine());


if(S > Total){
    Console.WriteLine("Gastos dentro do orçamento.");
}

else if(S < Total){
    Console.WriteLine("Orçamento estourado.");
}