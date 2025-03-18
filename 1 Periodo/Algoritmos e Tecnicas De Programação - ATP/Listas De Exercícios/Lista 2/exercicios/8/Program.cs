using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício___8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaração de variáveis //
            double litros, taxaf, ta1, te1, ta2, te2, ta3, te3, ta4, te4, f1, f2, f3, f4,
           ft;
            // Introdução + Leitura Litro //
            Console.WriteLine("Informe a quantidade de litros consumida:");
            litros = double.Parse(Console.ReadLine());
            // Testes + Calculos //
            taxaf = 305.55 + 226.05;
            f1 = f2 = f3 = f4 = 0;
            ta1 = 2.11;
            te1 = 1.56;
            ta2 = 4.496;
            te2 = 3.327;
            ta3 = 6.968;
            te3 = 5.156;
            ta4 = 9.512;
            te4 = 7.039;

            if (litros >= 0 && litros <= 75)
            {
                f1 = (litros * ta1) + (litros * te1);
                ft = f1 + taxaf;
                Console.WriteLine($"A fatura total é {ft}");
            }
            else if (litros >= 75 && litros <= 150)
            {
                f1 = (75 * ta1) + (75 * te1);
                f2 = ((litros - 75) * ta2) + ((litros - 75) * te2);
                ft = f1 + f2 + taxaf;
                Console.WriteLine($"A fatura total é {ft}");
            }
            else if (litros >= 150 && litros <= 225)
            {
                f1 = (75 * ta1) + (75 * te1);
                f2 = (150 * ta2) + (150 * te2);
                f3 = ((litros - 150) * ta3) + ((litros - 150) * te3);
                ft = f1 + f2 + f3 + taxaf;
                Console.WriteLine($"A fatura total é {ft}");
            }
            else if (litros >= 225 && litros <= double.MaxValue)
            {
                f1 = (75 * ta1) + (75 * te1);
                f2 = (150 * ta2) + (150 * te2);
                f3 = (255 * ta3) + (225 * te3);
                f4 = ((litros - 225) * ta4) + ((litros - 225) * te4);
                ft = f1 + f2 + f3 + f4 + taxaf;
                Console.WriteLine($"A fatura total é {ft}");
            }
            Console.ReadLine();
        }
    }
}