using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_1
{
    internal class Program
    {
        static int MenorNum(int n1, int n2, int n3, int n4)
        {
            if (n1 < n2 && n1 < n3 && n1 < n4)
            {
                return n1;
            }
            else if (n2 < n1 && n2 < n3 && n2 < n4)
            {
                return n2;
            }
            else if (n3 < n1 && n3 < n2 && n3 < n4)
            {
                return n3;
            }
            else
            {
                return n4;
            }
        }
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            Console.WriteLine("Informe o primeiro número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro número:");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o quarto número:");
            n4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"O menor número é o: {MenorNum(n1, n2, n3, n4)}");
            Console.ReadLine();
        }
    }
}