using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int pessoasComJoao = 2;

        Console.WriteLine("João tem " + idadeJoao);
        Console.WriteLine("Ele está com " + pessoasComJoao + " pessoas");

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (pessoasComJoao > 0)
            {
                Console.WriteLine("Ele está acompanhado. Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }

        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}