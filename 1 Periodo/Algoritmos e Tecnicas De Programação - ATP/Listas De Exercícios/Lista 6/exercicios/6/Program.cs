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
            // declaração de variáveis //
            char check = 'f';
            int[,] matriz = new int[4, 4];
            // Leitura da Matriz //
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Informe a posição da [linha {i}, coluna {j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            // Impressão da Matriz //
            Console.WriteLine("Matriz:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Leitura da matriz, com verificação das posições //
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[1, 0] == 0 && matriz[2, 0] == 0 && matriz[3, 0] == 0 && matriz[2, 1] == 0
                   && matriz[3, 1] == 0 && matriz[3, 2] == 0)
                    {
                        check = 'v';
                    }
                }
            }
            // Resultado dependendo da verificação //
            if (check == 'v')
            {
                Console.WriteLine("A matriz é um quadrado perfeito.");
            }
            else
            {
                Console.WriteLine("A matriz não é um quadrado perfeito.");
            }
            Console.ReadLine();
        }
    }
}