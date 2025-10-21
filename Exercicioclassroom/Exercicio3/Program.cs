int LadosIguais = 0;


Console.WriteLine("Quantos lados iguais contém o triângulo?");
LadosIguais = int.Parse(Console.ReadLine());

if(LadosIguais == 3){
    Console.WriteLine("Este triângulo é equilatero");
}

else if(LadosIguais == 2){
    Console.WriteLine("Este triângulo é Isoscele");
}

else if(LadosIguais == 0){
    Console.WriteLine("Este triângulo é Escaleno");
}