using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele esta acompanhado. Pode entrar");
            }
            else
            {
                Console.WriteLine("Nao pode entrar");
            }
        }

        Console.WriteLine("Enter para fechar");
        Console.ReadLine();
    }
}