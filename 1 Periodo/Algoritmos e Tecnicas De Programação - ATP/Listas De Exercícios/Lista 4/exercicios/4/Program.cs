using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Varáveis //
            double temp, maiort, menort;
            int dia, diamet, diamat;
            dia = 1;
            diamet = diamat = 0;
            menort = 100;
            maiort = -100;
            // for //
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Informe a temperatura do dia {dia}:");
                temp = int.Parse(Console.ReadLine());
                if (temp > maiort)
                {
                    maiort = temp;
                    diamat = i;
                }
                if (temp < menort)
                {
                    menort = temp;
                    diamet = i;
                }
                dia++;
            }
            Console.WriteLine("======================================================");
            Console.WriteLine($"A maior temperatura foi de {maiort} graus ocorreu no dia {diamat}");
        Console.WriteLine($"A menor temperatura foi de {menort} graus e ocorreu no dia {diamet}");
        Console.ReadLine();
        }
    }
}