using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            double ipd, ipdm, ipm, soma;
            int dia, diam;
            soma = 0;
            diam = 1;
            dia = 1;
            ipdm = 0;
            // Contador //
            while (dia <= 31)
            {
                Console.WriteLine($"Informe o índice pluviométrico do dia {dia}:");
                ipd = double.Parse(Console.ReadLine());
                if (ipd > ipdm)
                {
                    ipdm = ipd;
                    diam = dia;
                }
                soma = soma + ipd;
                dia++;
            }
            ipm = soma / 31;
            Console.WriteLine($"O índice pluviométrico médio é {ipm}");
            Console.WriteLine($"O índice pluviométrico máximo é {ipdm} e o dia que ele ocorreu foi {diam}");
            Console.ReadLine();
        }
    }
}