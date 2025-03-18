using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício___12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            int resp;
            double cm, m, mm;
            // Introdução + leitura de conversão //
            Console.WriteLine("MENU DE CONVERSÃO");
            Console.WriteLine("-----------------");
            Console.WriteLine("1. Converter de centímetros para metros. (DIGITE 1)");
            Console.WriteLine("2. Converter de metros para centímetros. (DIGITE 2)");
            Console.WriteLine("3. Converter de milímetros para metros. (DIGITE 3)");
            Console.WriteLine("4. Converter de metros para milímetros. (DIGITE 4)");
            Console.WriteLine("---------------------------------------------------");
            resp = int.Parse(Console.ReadLine());
            switch (resp)
            {
                case 1:
                    Console.WriteLine("Informe o valor em centímetros:");
                    cm = double.Parse(Console.ReadLine());
                    m = cm / 100;
                    Console.WriteLine($"A conversão de {cm} centímetros para metros dá um total de { m: f2} metros.");
            break;
                case 2:
                    Console.WriteLine("Informe o valor em metros:");
                    m = double.Parse(Console.ReadLine());
                    cm = m * 100;
                    Console.WriteLine($"A conversão de {m} metros para centímetros dá um total de { cm: f2} centímetros.");
            break;
                case 3:
                    Console.WriteLine("Informe o valor em milímetros:");
                    mm = int.Parse(Console.ReadLine());
                    m = mm / 1000;
                    Console.WriteLine($"A conversão de {mm} milímetros para metros dá um total de { m: f2} metros.");
            break;
                case 4:
                    Console.WriteLine("Informe o valor em metros:");
                    m = int.Parse(Console.ReadLine());
                    mm = m * 1000;
                    Console.WriteLine($"A conversão de {m} metros para milímetros dá um total de { mm: f2} milímetros.");
            break;
                default:
                    Console.WriteLine("Opção Inválida.");
                    break;
            }
            Console.ReadLine();
        }
    }
}