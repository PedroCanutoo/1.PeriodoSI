using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sab, f1, f2, f3, f4, dinss;
            char resp = 's';
            //
            do
            {
                Console.WriteLine("Informe o valor do salário bruto:");
                sab = double.Parse(Console.ReadLine());

                if (sab >= 0 && sab <= 1412.00)
                {
                    f1 = sab / 100 * 7.5;
                    dinss = f1;
                    Console.WriteLine($"Desconto do INSS: {dinss:f2}");

                }
                else if (sab >= 1412.01 && sab <= 2666.68)
                {
                    f1 = 1412.00 * 0.075;
                    f2 = (sab - 1412.00) * 0.09;
                    dinss = f1 + f2;
                    Console.WriteLine($"Desconto do INSS: {dinss:f2}");

                }
                else if (sab >= 2666.69 && sab <= 4000.03)
                {
                    f1 = 1412.00 * 0.075;
                    f2 = (2666.68 - 1412.00) * 0.09;
                    f3 = (sab - 2666.69) * 0.12;
                    dinss = f1 + f2 + f3;
                    Console.WriteLine($"Desconto do INSS: {dinss:f2}");
                }
                else if (sab >= 4000.04 && sab <= 7786.02)
                {
                    f1 = 1412.00 * 0.075;
                    f2 = (2666.68 - 1412.00) * 0.09;
                    f3 = (4000.03 - 2666.69) * 0.12;
                    f4 = (sab - 4000.04) * 0.14;
                    dinss = f1 + f2 + f3 + f4;
                    Console.WriteLine($"Desconto do INSS: {dinss:f2}");
                }
                Console.WriteLine("Quer informar um novo salário?:");
                resp = char.Parse(Console.ReadLine());
            }
            while (resp == 's');
        }
    }
}