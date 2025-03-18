using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício___4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis //
            int num;
            // Impressão + leitura //
            Console.WriteLine("Informe um número:");
            num = int.Parse(Console.ReadLine());
            // Verificação + Impressão //
            if (num % 15 == 0)
            {
                Console.WriteLine("Esse número é divisível por 3 e 5.");
            }
            else
            {
                Console.WriteLine("Esse número não é divisível por 3 e 5.");
            }
            Console.ReadLine();
        }
    }
}