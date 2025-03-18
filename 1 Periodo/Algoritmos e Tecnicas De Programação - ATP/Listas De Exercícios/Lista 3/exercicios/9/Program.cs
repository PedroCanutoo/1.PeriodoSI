using System;
namespace SerieFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Variáveis //
            double valorI, soma;
            int cont;
            valorI = 480;
            soma = 0;
            cont = 0;
            // While //
            while (cont < 30)
            {
                if (cont % 2 == 0)
                {
                    soma = soma + valorI;
                }
                else
                {
                    soma = soma - valorI;
                }
                valorI -= 5;
                cont++;
            }
            Console.WriteLine($"O valor final da série para 30 é: {soma}");
            Console.ReadLine();
        }
    }
}