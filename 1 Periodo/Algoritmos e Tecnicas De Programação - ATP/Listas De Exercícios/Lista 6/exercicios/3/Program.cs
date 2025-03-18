using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaração de vaiaveis //
            // matriz //
            double[,] matriz = new double[10, 10];
            // leitura da matriz //
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Informe a posição linha {i} coluna {j}");
                    matriz[i, j] = double.Parse(Console.ReadLine());
                }
            }
            // Impressão da matriz //
            Console.WriteLine();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Troca de elementos //
            for (int i = 0, j = 0; i < matriz.GetLength(0); i++, j++)
            {
                if (i == j)
                {
                    matriz[i, j] = Math.Sqrt(matriz[i, j]);
                }
            }
            // impressão da matriz com a troca de elementos da dp //
            Console.WriteLine();
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