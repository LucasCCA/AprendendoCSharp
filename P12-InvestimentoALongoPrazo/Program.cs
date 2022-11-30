using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 12 - Investimento a longo prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }
            fatorRendimento += 0.001;
        }
        Console.WriteLine(investimento);

        Console.WriteLine("Aperte enter");
        Console.ReadLine();
    }
}