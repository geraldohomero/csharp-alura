using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 9 - Escopo");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional; //----- a variável está dentro do escopo principal, podendo ser usada em todo o código

        if(acompanhado == true) 
        {
            textoAdicional = "João está acompanhado";
        }
        else
        {
            textoAdicional = "João não está acompanhado";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
        //{
            Console.WriteLine("Não pode entrar!"); //pode retirar as chaves caso tenha somente uma linha de código dentro desse escopo
        //}

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
