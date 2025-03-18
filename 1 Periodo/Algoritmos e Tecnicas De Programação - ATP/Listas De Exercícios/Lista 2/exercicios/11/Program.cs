using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício___11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            int num;
            // Introdução + Leitura de dados //
            Console.WriteLine("Informe um número entre 0 e 4:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            // Switch //
            switch (num)
            {
                case 1:
                    Console.WriteLine("Você digitou o número UM.");
                    break;
                case 2:
                    Console.WriteLine("Você digitou o número DOIS.");
                    break;
                case 3:
                    Console.WriteLine("Você digitou o número TRÊS.");
                    break;
                case 4:
                    Console.WriteLine("Você digitou o número QUATRO.");
                    break;
                default:
                    Console.WriteLine("Opção Inválida.");
                    break;
            }
            Console.ReadLine();
        }
    }
}