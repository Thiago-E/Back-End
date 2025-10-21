int Senha = 1234;

Console.WriteLine("Forneça a senha: ");
Senha = int.Parse(Console.ReadLine());

if (Senha == 1234) {
    Console.WriteLine("Acesso Permitido");
}
else {
    Console.WriteLine("Acesso Negado");
}