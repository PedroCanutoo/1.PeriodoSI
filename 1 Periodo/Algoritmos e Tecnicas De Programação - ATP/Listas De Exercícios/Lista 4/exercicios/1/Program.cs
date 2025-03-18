using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace _4___Lista_de_exercícios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double contped, pedreiros, valorp, m2, valorA, pass;
            for (contped = 1, pedreiros = 0; pedreiros <= 25; pedreiros++, contped++)
            {
                // Leitura de dados //
                Console.WriteLine("-------------------");
                Console.WriteLine($"PEDREIRO {contped}");
                Console.WriteLine("-------------------");
                Console.Write("Informe o valor do vale alimentação:");
                valorA = double.Parse(Console.ReadLine());
                Console.Write("Informe o valor do vale transporte:");
                pass = double.Parse(Console.ReadLine());
                Console.Write("Informe a quantidade de metros quadrados produzidos:");
                m2 = double.Parse(Console.ReadLine());
                // Teste de metros quadrados (qual valor vai ser usado) //
                if (m2 < 10)
                {
                    m2 = 10 * m2;
                }
                else if (m2 >= 10 && m2 <= 20)
                {
                    m2 = 11.50 * m2;
                }
                else
                {
                    m2 = 13.00 * m2;
                }
                pass = pass * 2; // Passagem * 2 (por conta de ser ida e volta) //
                valorp = valorA + pass + m2; // Soma do tota a ser pago //
                Console.WriteLine($"O valor total a ser pago para esse pedreiro: {valorp}");
            }
        }
    }
}