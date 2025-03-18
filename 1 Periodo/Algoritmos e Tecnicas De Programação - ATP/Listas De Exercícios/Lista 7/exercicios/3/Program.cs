using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_3
{
    internal class Program
    {
        static int MMC(int n1, int n2)
        {
        }
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 3)
            {
                Console.WriteLine("MENU DE OPÇÕES");
                Console.WriteLine("================");
                Console.WriteLine("1. Calcular MDC");
                Console.WriteLine("2. Calcular MMC");
                Console.WriteLine("3. SAIR");
                Console.WriteLine("----------------");
                Console.WriteLine("Digite a opção:");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    int n1, n2;
                    Console.WriteLine("Informe o primeiro número:");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o segundo número:");
                    n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"O MDC dos números {n1} e {n2} é: {}");
                }
                if (opcao == 2)
                {
                    int n1, n2, n3;
                    Console.WriteLine("Informe o primeiro número:");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o segundo número:");
                    n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o terceiro número:");
                    n3 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"O MMC dos números {n1}, {n2}, e {n3} é: {}");
                }
            }
        }
    }
}