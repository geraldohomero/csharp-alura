﻿using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto - Investindo a Longo prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for(int anos = 1; anos <= 5; anos++)
        {
            for(int mes = 1; mes<=12; mes++) //a variável mes só existe nesse for
            {
                investimento *= fatorRendimento;
            }
            
            fatorRendimento += 0.001;

        }

        Console.WriteLine ("Depois de 5 anos você terá R$ " + investimento);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}

