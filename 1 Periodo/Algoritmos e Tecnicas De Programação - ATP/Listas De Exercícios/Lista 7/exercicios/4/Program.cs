using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_4
{
    internal class Program
    {
        static double Medias(int n1, int n2, int n3, char letra)
        {
            if (letra == 'A' || letra == 'a')
            {
                double media = (n1 + n2 + n3) / 3;
                return media;
            }
            else if (letra == 'P' || letra == 'p')
            {
                double media = ((n1 * 5) + (n2 * 3) + (n3 * 2)) / 10.0;
                return media;
            }
            else
            {
                Console.WriteLine("Letra inválida. Impossível realizar algum cálculo.");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            int n1, n2, n3;
            char letra;
            Console.Write("Informe o valor de n1:");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de n2:");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de n3:");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("Informe a Letra:");
            letra = char.Parse(Console.ReadLine());
            double result = Medias(n1, n2, n3, letra);
            Console.WriteLine("---------------------");
            Console.WriteLine($"A média é: {result}");
            Console.ReadLine();
        }
    }
}