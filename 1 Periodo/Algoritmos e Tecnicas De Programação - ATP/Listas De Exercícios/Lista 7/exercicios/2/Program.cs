using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_2
{
    internal class Program
    {
        static double hipotenusa(double a, double b)
        {
            double result;
            result = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return result;
        }
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Informe o valor do cateto A:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do cateto B:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"O valor da hipotenusa é: {hipotenusa(a, b)}");
            Console.ReadLine();
        }
    }
}