using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercício_recomendado___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração De Variáveis //
            int n, cent, dez, uni, nInvertido;
            // Introdução + Leitura de número //
            Console.WriteLine("SEJA BEM VINDO AO INVERSOR DE NÚMEROS INTEIROS!");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.Write("Informe um número inteiro que contenha 3 digitos, no formato CDU (Centena, Dezena e Unidade):");
            n = int.Parse(Console.ReadLine());
            // Cálculos //
            cent = n / 100;
            dez = (n % 100) / 10;
            uni = n % 10;
            nInvertido = uni * 100 + dez * 10 + cent;
            // Final //
            Console.WriteLine("===============================");
            Console.WriteLine($"Número Invertido: {nInvertido}");
            Console.WriteLine("===============================");
            Console.ReadLine();
        }
    }
}