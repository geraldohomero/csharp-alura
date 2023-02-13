using System;
class Programa
{
    static void Main(string[] args)
    {
        Double salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro;
        salarioInteiro = (int)salario; //int só trabalha com até 32bites
        Console.WriteLine(salarioInteiro);

        int x = 2000000;
        Console.WriteLine(x);

        long y = 200000000000000000;
        Console.WriteLine(y);

        short z = 12000;
        Console.WriteLine(z);

        float altura = 1.77f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
