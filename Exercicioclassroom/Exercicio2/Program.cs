    int Time1 = 0;
    int Time2 = 0;

    Console.WriteLine("Como foi placar do primeiro time:? ");
    Time1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Como foi placar do segundo time:? ");
    Time2 = int.Parse(Console.ReadLine());

    if(Time1 > Time2){
    Console.WriteLine("O primeiro time ganhou");
    }

    else if(Time1 < Time2){
        Console.WriteLine("O segundo time ganhou");
    }

    else {
        Console.WriteLine("Ambos empataram");
    }
