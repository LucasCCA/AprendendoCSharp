using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 10 - Calcula poupanca");

        double investimento = 1000;

        //rendimento de 0.5% ao mes

        int mes = 1;

        while (mes <= 12)
        {
            investimento += investimento * 0.005;
            Console.WriteLine("No mes " + mes + " voce tem " + investimento);

            mes++;
        }

        Console.WriteLine("Aperte enter");
        Console.ReadLine();
    }
}