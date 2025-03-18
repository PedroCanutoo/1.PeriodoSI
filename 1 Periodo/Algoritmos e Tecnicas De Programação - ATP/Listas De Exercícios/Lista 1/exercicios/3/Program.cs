using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercício___3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            double c, f;
            // Introdução + Leitura de Valor °F //
            Console.WriteLine("SEJA BEM VINDO AO CONVERSOR DE TEMPERATURA");
            Console.WriteLine("------------apenas °F para °C-------------");
            Console.WriteLine("Para começar, informe o valor da temperatura em °F:");
            f = double.Parse(Console.ReadLine());
            // Cáculo de Conversão //
            c = (f - 32) / 1.8;
            // Tabela de Conversão //
            Console.WriteLine("===============TABELA DE CONVERSÃO================");
            Console.WriteLine($"Temperatura informada: {f}°F");
            Console.WriteLine($"Temperatura convertida: {c}°C");
            Console.WriteLine("==================================================");
            Console.ReadLine();
        }
    }
}