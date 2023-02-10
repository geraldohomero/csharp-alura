using System;
class Programa
{
    static void Main(string[] args)
    {
        Double salario;
        salario = 3000.15;

        int salarioInteiro;
        salarioInteiro = (int)salario; //int só trabalha com até 32bites

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
