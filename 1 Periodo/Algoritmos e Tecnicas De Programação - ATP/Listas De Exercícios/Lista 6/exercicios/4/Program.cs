using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double somacP = 0, somaC35 = 0, somaC12 = 0;
            double[,] matriz = new double[3, 6];
            // Leitura da matriz //
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Informe a posição [linha {i}, coluna {j}]:");
                    matriz[i, j] = double.Parse(Console.ReadLine());
                }
            }
            // imprimindo matriz //
            Console.WriteLine();
            Console.WriteLine("Matriz");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // somando elementos das colunas pares da matriz //
            for (int j = 0; j < matriz.GetLength(1); j = j + 2)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    somacP = somacP + matriz[i, j];
                }
            }
            Console.WriteLine($"A soma das colunas pares é: {somacP}");
            // soma das colunas 3 e 5 //
            for (int j = 3; j < matriz.GetLength(1); j = j + 2)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    somaC35 = somaC35 + matriz[i, j];
                }
            }
            Console.WriteLine($"Soma coluna 3 e 5: {somaC35}");
            Console.WriteLine();
            // soma das colunas 1 e 2 //
            for (int j = 1; j < matriz.GetLength(1); j++)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    if (j == 1 || j == 2)
                    {
                        somaC12 = somaC12 + matriz[i, j];
                    }
                }
            }
            // substituição dos elementos da coluna 5 pela soma das c12 //
            for (int j = 5; j < matriz.GetLength(1); j++)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    matriz[i, j] = somaC12;
                }
            }
            // imprimindo matriz //
            Console.WriteLine("Matriz com elementos da coluna 5 com o valor da soma da coluna 1 e 2");
        for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}