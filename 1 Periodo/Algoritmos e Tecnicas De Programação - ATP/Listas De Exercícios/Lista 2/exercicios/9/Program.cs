using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício___9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            string emp, nf, cargo;
            double sab, dinss, vl, f1, f2, f3, f4;
            // Introdução + Leitura de dados //
            Console.WriteLine("Informe o nome da empresa:");
            emp = Console.ReadLine();
            Console.WriteLine("Informe o nome do funcionário:");
            nf = Console.ReadLine();
            Console.WriteLine("Informe o cargo do funcionário:");
            cargo = Console.ReadLine();
            Console.WriteLine("Informe o salário bruto do funcionário:");
            sab = double.Parse(Console.ReadLine());
            f1 = 0;
            // Cálculos //
            if (sab >= 0 && sab <= 1412.00)
            {
                f1 = sab / 100 * 7.5;
                dinss = f1;
                vl = sab - dinss;
                Console.WriteLine($"Nome do funcionário: {nf}");
                Console.WriteLine($"Cargo do funcionário: {cargo}");
                Console.WriteLine($"Salário bruto: {sab:f2}");
                Console.WriteLine($"Desconto do INSS: {dinss:f2}");
                Console.WriteLine($"Valor líquido: {vl:f2}");
            }
            else if (sab >= 1412.01 && sab <= 2666.68)
            {
                f1 = 1412.00 * 0.075;
                f2 = (sab - 1412.00) * 0.09;
                dinss = f1 + f2;
                vl = sab - dinss;
                Console.WriteLine($"Nome do funcionário: {nf}");
                Console.WriteLine($"Cargo do funcionário: {cargo}");
                Console.WriteLine($"Salário bruto: {sab:f2}");
                Console.WriteLine($"Desconto do INSS: {dinss:f2}");
                Console.WriteLine($"Valor líquido: {vl:f^2}");
            }
            else if (sab >= 2666.69 && sab <= 4000.03)
            {
                f1 = 1412.00 * 0.075;
                f2 = (2666.68 - 1412.00) * 0.09;
                f3 = (sab - 2666.69) * 0.12;
                dinss = f1 + f2 + f3;
                vl = sab - dinss;
                Console.WriteLine($"Nome do funcionário: {nf}");
                Console.WriteLine($"Cargo do funcionário: {cargo}");
                Console.WriteLine($"Salário bruto: {sab:f2}");
                Console.WriteLine($"Desconto do INSS: {dinss:f2}");
                Console.WriteLine($"Valor líquido: {vl:f2}");
            }
            else if (sab >= 4000.04 && sab <= 7786.02)
            {
                f1 = 1412.00 * 0.075;
                f2 = (2666.68 - 1412.00) * 0.09;
                f3 = (4000.03 - 2666.69) * 0.12;
                f4 = (sab - 4000.04) * 0.14;
                dinss = f1 + f2 + f3 + f4;
                vl = sab - dinss;
                Console.WriteLine($"Nome do funcionário: {nf}");
                Console.WriteLine($"Cargo do funcionário: {cargo}");
                Console.WriteLine($"Salário bruto: {sab:f2}");
                Console.WriteLine($"Desconto do INSS: {dinss:f2}");
                Console.WriteLine($"Valor líquido: {vl:f2}");
            }
            Console.ReadLine();
        }
    }
}