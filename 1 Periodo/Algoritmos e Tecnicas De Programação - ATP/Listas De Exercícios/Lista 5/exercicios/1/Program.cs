using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperatura = new double[5];
            double temp;
            for (int i = 0; i < temperatura.Length; i++)
            {
                Console.WriteLine($"Informe a temperatura do dia {i + 1}:");
                temperatura[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Informe a temperatura a pesquisar:");
            temp = double.Parse(Console.ReadLine());
            Console.Write("Essa temperatura ocorreu nos seguintes dias:");
            for (int i = 0; i < temperatura.Length; i++)
            {
                if (temp == temperatura[i])
                {
                    Console.Write(i + 1);
                    Console.Write(",");
                }
            }
            Console.ReadLine();
        }
    }
}