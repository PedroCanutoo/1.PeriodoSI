using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício___5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            int idade;
            // Impressão + Leitura de idade //
            Console.WriteLine("Informe a idade do nadador:");
            idade = int.Parse(Console.ReadLine());
            // Verificação + Impressão //
            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Esse nadador está na categoria: INFANTIL A.");
            }
            else if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Esse nadador está na categoria: INFANTIL B.");
            }
            else if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Esse nadador está na categoria: JUVENIL A.");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Esse nadador está na categoria: JUVENIL B.");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("Esse nadador está na categoria: Sênior.");
            }
            else
            {
                Console.WriteLine("Esse nanador não se enquadra em nenhuma categoria.");
            }
            Console.ReadLine();
        }
    }
}