using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercício___6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            double n, d, result;
            // Introdução + leitura de Var(d, n) //
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Para montar sua fração, siga os passos abaixo:");
            Console.Write("Informe o numerador da sua fração:");
            n = double.Parse(Console.ReadLine());
            Console.Write("Agora, informe o denominador:");
            d = double.Parse(Console.ReadLine());
            // Cálculos Das Variáveis //
            result = n / d;
            // Resultado da fração //
            Console.WriteLine("==================================================");
            Console.WriteLine($" ~ O resultado da fração informada é: {result:F2}");
            Console.WriteLine("==================================================");
            Console.ReadLine();
        }
    }
}