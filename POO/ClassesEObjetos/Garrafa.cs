namespace ClassesEObjetos;

public class Garrafa
{
    //propriedades
    public double qtdLitros;

    public string marca = "";

    public string cor = "";

    //metodos
    public void Tampar()
    {
        System.Console.WriteLine($"A garrafa está tampada");

    }

    public void Destampar()
    {
        System.Console.WriteLine($"A garrafa está destampada");
    }

    public void Encher()
    {
        System.Console.WriteLine($"A garrafa está enchendo");
    }

    public void Esvaziar()
    {
        System.Console.WriteLine($"A garrafa está esvaziando");
    }
}
