using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            int quantD;
            // //
            Console.WriteLine("Quantos dígitos terá o número:");
            quantD = int.Parse(Console.ReadLine());
            int[] palindromo = new int[quantD];
            for (int i = 0; i < palindromo.Length; i++)
            {
                Console.WriteLine($"Informe o {i + 1} digito do seu número");
                palindromo[i] = int.Parse(Console.ReadLine());
            }
            bool teste = true;
            for (int i = 0, final = (palindromo.Length - 1); i < (palindromo.Length / 2); i++, final--)
            {
                if (palindromo[i] != palindromo[final])
                {
                    teste = false;
                }
            }
            if (teste == true)
            {
                Console.WriteLine("é verdadeiro");
            }
            else
            {
                Console.WriteLine("é falso");
            }
            Console.ReadLine();
        }
    }
}