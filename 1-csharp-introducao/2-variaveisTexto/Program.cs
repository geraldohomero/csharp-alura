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

        letra = (char)(65 + 1); //ASCII Table
        Console.WriteLine(letra);

        string primeiraFrase = "Baum di mais ";
        Console.WriteLine(primeiraFrase + 2023);

        string vazia = "";
        Console.WriteLine(vazia); //string pode ser vazia, mas o char não

        string listaCursos = @"Cursos disponíveis: 
        - Python
        - C#
        - Java
        - JavaScript";
        Console.WriteLine(listaCursos);


        Console.WriteLine("Tecle ENTER para fechar ...");
        Console.ReadLine();
    }    
}
