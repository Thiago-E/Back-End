  int quantidade;
        double precoPorUnidade, total;

        Console.WriteLine("Quantas maçãs você deseja comprar?");
        quantidade = int.Parse(Console.ReadLine());

    
        if (quantidade < 12)
        {
            precoPorUnidade = 0.30;
        }
        else
        {
            precoPorUnidade = 0.25;
        }

    
        total = quantidade * precoPorUnidade;

    
        Console.WriteLine($"Valor total da compra: R$ {total:F2}");