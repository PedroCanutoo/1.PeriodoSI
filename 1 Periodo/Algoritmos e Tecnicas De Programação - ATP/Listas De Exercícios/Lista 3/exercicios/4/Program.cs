using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis //
            int np, idade, cont1, cont2, cont3, cont4, cont5, contp;
            double pc;
            cont1 = cont2 = cont3 = cont4 = cont5 = 0;
            idade = 0;
            contp = 0;
            // Introdução + Leitura //
            Console.WriteLine("Informe a quantidade de pessoas:");
            np = int.Parse(Console.ReadLine());
            while (contp < np)
            {
                Console.WriteLine("Informe a idade:");
                idade = int.Parse(Console.ReadLine());
                if (idade >= 1 && idade <= 15)
                {
                    cont1++;
                }
                else if (idade >= 16 && idade <= 30)
                {
                    cont2++;
                }
                else if (idade >= 31 && idade <= 45)
                {
                    cont3++;
                }
                else if (idade >= 46 && idade <= 60)
                {
                    cont4++;
                }
                else if (idade >= 60)
                {
                    cont5++;
                }
                contp++;
            }
            Console.WriteLine($"[1 - 15]: {cont1} pessoas. {cont1 * 100.0 / np}% do total de pessoas.");
           
            Console.WriteLine($"[16 - 30]: {cont2} pessoas. {cont2 * 100.0 / np}% do total de pessoas.");
           
            Console.WriteLine($"[31 - 45]: {cont3} pessoas. {cont3 * 100.0 / np}% do total de pessoas.");
           
            Console.WriteLine($"[46 - 60]: {cont4} pessoas.{cont4 * 100.0 / np}% do total de pessoas.");
           
            Console.WriteLine($"[>= 60]: {cont5} pessoas.{cont5 * 100.0 / np}% do total de pessoas.");
            Console.ReadKey();
        }
    }
}