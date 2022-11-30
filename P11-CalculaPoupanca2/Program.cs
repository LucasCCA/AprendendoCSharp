using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 11 - Calcula poupanca");

        double investimento = 1000;

        //rendimento de 0.5% ao mes

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mes " + mes + " voce tem " + investimento);
        }

        Console.WriteLine("Aperte enter");
        Console.ReadLine();
    }
}