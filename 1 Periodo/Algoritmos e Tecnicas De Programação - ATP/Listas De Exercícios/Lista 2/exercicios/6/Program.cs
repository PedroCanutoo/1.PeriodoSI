using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício___6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            double w, x, y, z;
            // Impressão + Leitura //
            Console.WriteLine("Informe qual média será usada: Geométrica(1), Ponderada(2),Harmônica(3), Aritmética(4).");
           
            w = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o primeiro valor:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro valor:");
            z = double.Parse(Console.ReadLine());
            double result;
            // Verificação + Impressão //
            if (w == 1)
            {
                result = Math.Sqrt(x * z * y);
                Console.WriteLine($"A média geométrica dos números informados é: {result: f2}");
            }
            else if (w == 2)
            {
                result = (x + 2 * y + 3 * z) / 6;
                Console.WriteLine($"A média ponderada dos números informados é: {result: f2}");
            }
            else if (w == 3)
            {
                result = 3 / (1 / x + 1 / y + 1 / z);
                Console.WriteLine($"A media harmônica dos números informados é: { result: f2}");
            }
            else if (w == 4)
            {
                result = (x + y + z) / 3;
                Console.WriteLine($"A média aritmética dos números informados é:{ result: f2}");
            }
            Console.ReadLine();
        }
    }
}