﻿using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65; //ASCII Table
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);


        Console.WriteLine("Tecle ENTER para fechar ...");
        Console.ReadLine();
    }    
}
