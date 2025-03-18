using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
namespace exe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linha, coluna;
            int diagonalP = 0;
            int diagonalS = 0;
            Console.WriteLine("Informe a quantidade de linhas da matriz:");
            linha = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de colunas da matriz:");
            coluna = int.Parse(Console.ReadLine());
            int[,] matriz = new int[linha, coluna];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Informe a posição linha {i} coluna {j}:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            // Soma das Linhas //
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int somaL = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    somaL = somaL + matriz[i, j];
                }
                Console.WriteLine($"A soma da linha {i} é: {somaL}");
            }
            Console.WriteLine();
            // Soma das Colunas //
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                int somaC = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    somaC = somaC + matriz[i, j];
                }
                Console.WriteLine($"A soma da coluna {j} é: {somaC}");
            }
            Console.WriteLine();
            // Soma da Diagonal Principal //
            for (int i = 0, j = 0; i < matriz.GetLength(0); i++, j++)
            {
                diagonalP = diagonalP + matriz[i, j];
            }
            Console.WriteLine($"A soma da diagonal Principal é {diagonalP}");
            // Soma da Diagonal Secundária //
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                diagonalS = diagonalS + matriz[i, matriz.GetLength(0) - 1 - i];
            }
            Console.WriteLine($"A soma da diagonal Secundária é {diagonalS}");
            Console.ReadLine();


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