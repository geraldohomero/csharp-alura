using System;

class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Mostra os números múltiplos de 3 < 100");
        for (int i = 1; i < 100; i++ )
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}