using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            double x, y;
            x = -1;
            y = -1;
            // switch //
            while (x != 0 && y != 0)
            {
                Console.WriteLine("Informe o valor de X:");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor de Y:");
                y = double.Parse(Console.ReadLine());
                if (x >= 0.01 && y >= 0.01)
                {
                    Console.WriteLine("Este ponto pertence ao primeiro quadrante.");
                }
                else if (x < -0.99 && y > 0.01)
                {
                    Console.WriteLine("Este ponto pertence ao segundo quadrante.");
                }
                else if (x < -0.99 && y < -0.99)
                {
                    Console.WriteLine("Este ponto pertence ao terceiro quadrante.");
                }
                else if (x < -0.99 && y < -0.99)
                {
                    Console.WriteLine("Este ponto pertence ao terceiro quadrante.");
                }
                else if (x > 0.01 && y < -0.99)
                {
                    Console.WriteLine("Este ponto pertence ao quarto quadrante.");
                }
            }
        }
    }
}