using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercício___7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            double d, pGo, gor, valorT;
            // Introdução + Leitura de Variáveis (d, g)
            Console.WriteLine("---------------------------------------------------------------------");
            Console.Write("Informe o valor do gasto com despesas do restaurante:");
            d = double.Parse(Console.ReadLine());
            Console.Write("Agora, informe o percentual da gorjeta que você gostaria de dar:");
            pGo = double.Parse(Console.ReadLine());
            // Cálculo de Valores das Variáveis //
            gor = d / 100 * pGo;
            valorT = d + gor;
            // Final //
            Console.WriteLine("============================================");
            Console.WriteLine($"O valor da gorjeta foi de: R${gor}");
            Console.WriteLine($"O valor total a ser pago foi de: R${valorT}");
            Console.WriteLine("============================================");
            Console.ReadLine();
        }
    }
}