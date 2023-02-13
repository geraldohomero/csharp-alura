using System;

class Programa
{
    static void Main(String[] args)
    {
        for(int linha = 0; linha < 9; linha++)
        {
            for (int coluna = 0; coluna < 9; coluna++)
            {
                if (coluna > linha)
                {
                    break;
                }
                Console.Write(coluna+1);
            }
            Console.WriteLine();
        }
    }
}