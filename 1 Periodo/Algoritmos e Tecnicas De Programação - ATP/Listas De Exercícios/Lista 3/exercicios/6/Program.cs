using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace exercício_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            int resp, mes;
            double sa, novosa, saferias, dec3;
            resp = 0;
            novosa = 0;
            // Menu //
            while (resp != 4)
            {
                Console.WriteLine("========================");
                Console.WriteLine("[1] Novo Salário");
                Console.WriteLine("[2] Férias");
                Console.WriteLine("[3] Décimo Terceiro");
                Console.WriteLine("[4] Sair");
                Console.WriteLine("========================");
                resp = int.Parse(Console.ReadLine());
                if (resp == 1)
                {
                    Console.WriteLine("Informe o seu salário:");
                    sa = double.Parse(Console.ReadLine());
                    if (sa >= 0)
                    {
                        if (sa >= 0 && sa <= 999.99)
                        {
                            novosa = sa + (sa / 100 * 15);
                            Console.WriteLine($"Novo Salário: {novosa}");
                        }
                        else if (sa >= 1000 && sa <= 2000)
                        {
                            novosa = sa + (sa / 100 * 10);
                            Console.WriteLine($"Novo Salário: {novosa}");
                        }
                        else
                        {
                            novosa = sa + (sa / 100 * 5);
                            Console.WriteLine($"Novo Sálario: {novosa}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Salário Inválido, repita o processo!");
                    }
                }
                if (resp == 2)
                {
                    Console.WriteLine("Informe o seu sálario:");
                    sa = double.Parse(Console.ReadLine());
                    if (sa >= 0)
                    {
                        saferias = sa + (sa / 3);
                        Console.WriteLine($"O valor de suas férias é: {saferias:f2}");
                    }
                    else
                    {
                        Console.WriteLine("Informe um salário válido!");
                    }
                }
                if (resp == 3)
                {
                    Console.WriteLine("Informe o seu salário:");
                    sa = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o número de messes de trabalho na empresa:");
                    mes = int.Parse(Console.ReadLine());
                    if (sa < 0)
                    {
                        Console.WriteLine("Informe um salário válido!");
                    }
                    else if (sa >= 0 && mes >= 1 && mes <= 12)
                    {
                        dec3 = sa / 12 * mes;
                        Console.WriteLine($"O valor do decímo terceiro é: {dec3:f2}.");
                    }
                    else
                    {
                        Console.WriteLine("Informe um mês válido!");
                    }
                }
            }
        }
    }
}