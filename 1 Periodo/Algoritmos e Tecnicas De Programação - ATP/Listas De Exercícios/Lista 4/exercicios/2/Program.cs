using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
namespace exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            int n, fat;
            double soma = 1.0;
            fat = 1;
            Console.WriteLine("Informe um valor inteiro e positivo:");
            n = int.Parse(Console.ReadLine());
            // Calcula o fatorial
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
                soma = soma * 1 / fat;
            }
            Console.WriteLine($"A soma S até 1/{n}! é: {soma}");
            Console.ReadLine();
        }
    }
}