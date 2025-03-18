using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração Variáveis //
            int cont, n, n1, n2, n3;
            cont = 0;
            n1 = 0;
            n2 = 1;
            // Introdução + Leitura de números //
            Console.WriteLine("Informe até qual número você quer que vá a sequência de fibonacci: ");
           
            n = int.Parse(Console.ReadLine());

            // While //
            while (cont <= n)
            {
                Console.WriteLine(n1);
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                cont++;
            }
            Console.ReadLine();
        }
    }
}