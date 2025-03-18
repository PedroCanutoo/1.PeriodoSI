using System;
namespace Exercício___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            double b, h, p, a, d;
            // Introdução + Valor (b, h) //
            Console.WriteLine("Seja bem vindo ao CALCULADOR DE MEDIDAS RETANGULARES!");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Para começar, informe o valor da base do retângulo:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora, informe o valor da altura do retângulo:");
            h = double.Parse(Console.ReadLine());
            // Cálculo Das Medidas (perímetro, área e diagonal) //
            p = 2 * (b + h);
            a = b * h;
            d = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
            // Tabela de valores das Medidas //
            Console.WriteLine("=================MEDIDAS DO RETÂNGULO================");
            Console.WriteLine($"Perímetro: {p}");
            Console.WriteLine($"Área: {a}");
            Console.WriteLine($"Diagonal: {d:F2}");
            Console.WriteLine("=====================================================");
            Console.ReadLine();
        }
    }
}