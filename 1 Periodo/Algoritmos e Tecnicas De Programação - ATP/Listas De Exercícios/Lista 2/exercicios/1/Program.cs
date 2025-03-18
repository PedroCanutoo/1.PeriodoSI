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
            int num;
            Console.WriteLine("Informe um valor entre 0 e 5");
            num = int.Parse(Console.ReadLine());
            if (num < 0 || num > 5)
            {
                Console.WriteLine("Número Inválido");
            }
            else if (num == 0)
            {
                Console.WriteLine("O número informado foi ZERO.");
            }
            else if (num == 1)
            {
                Console.WriteLine("O número informado foi UM.");
            }
            else if (num == 2)
            {
                Console.WriteLine("O número informado foi DOIS.");
            }
            else if (num == 3)
            {
                Console.WriteLine("O número informado foi TRÊS.");
            }
            else if (num == 4)
            {
                Console.WriteLine("O número informado foi QUATRO.");
            }
            else if (num == 5)
            {
                Console.WriteLine("O número informado foi CINCO.");
            }
            Console.ReadLine();
        }
    }
}