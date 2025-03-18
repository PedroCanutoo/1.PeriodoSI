using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            int cont;
            cont = 10;
            // Contador //
            while (cont >= 1)
            {
                Console.WriteLine(cont);
                cont--;
            }
            Console.WriteLine("Feliz Ano Novo!");
            Console.ReadLine();
        }
    }
}