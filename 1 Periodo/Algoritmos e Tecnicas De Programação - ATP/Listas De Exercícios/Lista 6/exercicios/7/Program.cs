using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n, entrada = 0, cont = 0;
            Console.WriteLine("Informe a quantidade de linhas da matriz:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de colunas da matriz:");
            n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[m, n];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Informe a posição [linha {i}, coluna {j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); i++)
                {
                    if (matriz[i, j] == 0)
                    {

                    }
                }
            }

            // parei nessa parte e nao consegui mais //
        }
    }
}