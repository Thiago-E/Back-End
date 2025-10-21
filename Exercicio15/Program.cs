 double n1, n2, n3, n4, media;

 Console.WriteLine("Digite o primeiro nota");
n1 = double.Parse( Console.ReadLine());

Console.WriteLine("Digite o segundo nota"); 
n2 = double.Parse( Console.ReadLine());

Console.WriteLine("Digite o terceira nota");
n3 = double.Parse( Console.ReadLine());

Console.WriteLine("Digite o quarta nota") ;
n4 = double.Parse( Console.ReadLine());


media = (n1 + n2 + n3 + n4) / 4;
    Console.WriteLine("Media da nota: " + (media));

if (media > 5){
    Console.WriteLine("O aluno foi aprovado");
}

else if( media < 5){
    Console.WriteLine("O aluno está em recuperação");
}

else if(media >= 5){
    Console.WriteLine("O aluno foi aprovado");
}
