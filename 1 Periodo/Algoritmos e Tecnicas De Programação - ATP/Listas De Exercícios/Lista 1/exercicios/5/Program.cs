using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercício___5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            double varA, varB, varC;
            // Introdução + Leitura (varA, varB) //
            Console.WriteLine("-----------------------------");
            Console.Write("Digite o valor da variável A:");
            varA = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da variável B:");
            varB = double.Parse(Console.ReadLine());
            // Cálculos Váriaveis //
            varC = varA;
            varA = varB;
            varB = varC;
            // Valores Finais //
            Console.WriteLine("=============================");
            Console.WriteLine($"varA: {varA}");
            Console.WriteLine($"varB: {varB}");
            Console.WriteLine("=============================");
            Console.ReadLine();
        }
    }
}