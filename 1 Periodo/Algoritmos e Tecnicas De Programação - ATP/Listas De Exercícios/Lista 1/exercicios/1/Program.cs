using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercício___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração De Variáveis //
            double l, p, a, d, raiz2;
            // Introdução + Pedido de valor do lado do quadrado + Armazenamento do valor //
            Console.WriteLine("Seja bem vindo ao CALCULADOR DE MEDIDAS DE QUADRADOS");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Para começar, informe o valor do lado do quadrado:");
            l = double.Parse(Console.ReadLine());
            // Cálcula Das Medidas (raiz, perímetro, área e diagonal) //
            raiz2 = Math.Sqrt(2);
            p = l * 4;
            a = Math.Pow(l, 2);
            d = raiz2 * l;
            // Tabela de exibição de Medidas //
            Console.WriteLine("=================MEDIDAS DO QUADRADO================");
            Console.WriteLine($"Perímetro: {p}");
            Console.WriteLine($"Área: {a}");
            Console.WriteLine($"Diagonal: {d}");
            Console.WriteLine("====================================================");
            Console.ReadLine();
        }
    }
}