using System;
namespace Exercício__04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração De Variáveis //
            double el, vBrancos, vNulos, vValidos, vTot, naoV;
            // Introdução + Leitura de Valores //
            Console.WriteLine("SEJA BEM VINDO AO CONTADOR DE VOTOS!");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Informe a quantidade de eleitores que há no município:");
            el = double.Parse(Console.ReadLine());
            Console.Write("Agora, seguindo essa ordem (1. Votos Brancos / 2. Votos Nulos / 3. Votos Válidos) informe a quantidade de votos: ");
           
            vBrancos = double.Parse(Console.ReadLine());
            vNulos = double.Parse(Console.ReadLine());
            vValidos = double.Parse(Console.ReadLine());
            // Cálculos Das Varáveis //
            vTot = vBrancos + vNulos + vValidos;
            vBrancos = 100 * vBrancos / vTot;
            vNulos = 100 * vNulos / vTot;
            vValidos = 100 * vValidos / vTot;
            naoV = el - vTot;
            // Tabela de Informações (Votos) //
            Console.WriteLine($"============INFORMAÇÕES DA ELEIÇÃO=============");
            Console.WriteLine($"A cidade teve um total de {el} eleitores.");
            Console.WriteLine($"No total, foram computados {vTot} votos.");
            Console.WriteLine($"Dentre esses {el} eleitores, {naoV} não votaram");
            Console.WriteLine("------------- % de votos computados ------------");
            Console.WriteLine($" ~ Votos em Branco: {vBrancos:F2}.");
            Console.WriteLine($" ~ Votos Nulos: {vNulos:F2}.");
            Console.WriteLine($" ~ Votos Válidos: {vValidos:F2}.");
            Console.WriteLine("================================================");
            Console.ReadLine();
        }
    }
}