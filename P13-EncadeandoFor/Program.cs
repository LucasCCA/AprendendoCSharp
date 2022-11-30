using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 13 - Encadeando for");

        //*
        //**
        //***
        //****
        //*****

        //com break
        for (int linhas = 0; linhas < 10; linhas++)
        {
            for (int colunas = 0; colunas < 10; colunas++)
            {
                Console.Write("*");
                if (colunas >= linhas)
                {
                    break;
                }
            }
            Console.WriteLine();
        }

        //sem break
        for (int linhas = 0; linhas < 10; linhas++)
        {
            for (int colunas = 0; colunas <= linhas; colunas++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Aperte enter");
        Console.ReadLine();
    }
}