using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 8 - Condicionais 2");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = false;

        if (idadeJoao >= 18 || grupo)
        {
            Console.WriteLine("Pode entrar");
        }
        else
        {
            Console.WriteLine("Nao pode entrar");
        }

        Console.WriteLine("Enter para fechar");
        Console.ReadLine();
    }
}