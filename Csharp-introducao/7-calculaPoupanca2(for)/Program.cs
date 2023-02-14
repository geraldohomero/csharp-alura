using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Poupança 2");


        /*
        while (mes <= 24)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem R$" + investimento);

            //mes = mes + 1;
            //mes += 1;
            mes ++;
        }
        */
        
        double investimento = 1000;
   
        for (int mes = 1; mes <= 24; mes++)
        {
            investimento = investimento + investimento * 0.005;
            //ou investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem R$" + investimento);
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
