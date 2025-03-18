using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis //
            int x, y;
            // Introdução + Leitura //
            Console.WriteLine("Informe o valor de X:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de Y:");
            y = int.Parse(Console.ReadLine());

            while (x % 2 == 0 || y % 2 == 0 || x > y)
            {
                Console.WriteLine("Erro! Valores Inválidos.");
                Console.WriteLine("Informe o valor de X:");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor de Y:");
                y = int.Parse(Console.ReadLine());
            }
            while (x <= y)
            {
                Console.WriteLine(x);
                x = x + 2;
            }
            Console.ReadLine();

        }
    }
}