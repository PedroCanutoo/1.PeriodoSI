using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vetA = new double[10];
            double[] vetB = new double[10];
            char[] vetC = new char[10];
            double[] vetD = new double[10];

            Console.WriteLine("Digite 10 elementos para o VetA:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vetA[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Digite 10 elementos para o VetB:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vetB[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Digite 10 operações (+, -, *, /) para o VetC:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Operação {i + 1}: ");
                vetC[i] = Convert.ToChar(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                switch (vetC[i])
                {
                    case '+':
                        vetD[i] = vetA[i] + vetB[i];
                        break;
                    case '-':
                        vetD[i] = vetA[i] - vetB[i];
                        break;
                    case '*':
                        vetD[i] = vetA[i] * vetB[i];
                        break;
                    case '/':
                        if (vetB[i] != 0)
                        {
                            vetD[i] = vetA[i] / vetB[i];
                        }
                        else
                        {
                            Console.WriteLine($"Divisão por zero em operação {i + 1}. Resultado definido como 0.");
                           
                            vetD[i] = 0;
                        }
                        break;
                    default:
                        Console.WriteLine($"Operação inválida {i + 1}: {vetC[i]}");
                        vetD[i] = 0;
                        break;
                }
            }

            Console.WriteLine("Resultado do VetD:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: {vetD[i]}");
            }
        }
    }
}