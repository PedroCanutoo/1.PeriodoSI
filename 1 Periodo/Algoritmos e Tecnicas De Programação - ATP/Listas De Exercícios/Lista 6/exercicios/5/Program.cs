using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int somaL1 = 0;
            int[,] matriz = new int[3, 3];
            // Leitura da Matriz //
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Informe a posição da [linha {i}, coluna {j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            // Imprimindo matriz //
            Console.WriteLine();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Soma das linhas //
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        somaL1 = somaL1 + matriz[i, j];
                    }
                }
            }
            Console.WriteLine(somaL1);
            Console.ReadLine();
        }
    }
}