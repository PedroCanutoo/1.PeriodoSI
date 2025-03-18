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
            int n, m;
            string comparacao = "nada";
            Console.WriteLine("Informe a quantidade de linhas das matrizes:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de colunas das matrizes:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Matriz 1");
            int[,] matriz1 = new int[n, m];
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write($"Informe a posição da linha {i} coluna {j}:");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Matriz 2");
            int[,] matriz2 = new int[n, m];
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.Write($"Informe a posição da linha {i} coluna {j}:");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0, check = 0; i < matriz1.GetLength(0) || check == 1; i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    if (matriz1[i, j] == matriz2[i, j])
                    {
                        comparacao = "são iguais";
                    }
                    else
                    {
                        comparacao = "não são iguais";
                        check++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"As matrizes {comparacao}");
            Console.ReadLine();
        }
    }
}