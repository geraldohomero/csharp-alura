using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int pessoasComJoao = 2;

        bool acompanhado = pessoasComJoao > 0;
        bool grupo = true;

        Console.WriteLine("João tem " + idadeJoao);
        Console.WriteLine("Ele está com " + pessoasComJoao + " pessoas");

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {

            Console.WriteLine("Não pode entrar!");
           
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}