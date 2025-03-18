using System;
namespace exe_6
{
    internal class Program
    {
        static void MultiplicarEscalar(int[,] MatrizA, int n)
        {

            for (int i = 0; i < MatrizA.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizA.GetLength(1); j++)
                {
                    MatrizA[i, j] = MatrizA[i, j] * n;
                }
            }
            Console.WriteLine("Matriz resultante:");
            for (int i = 0; i < MatrizA.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizA.GetLength(1); j++)
                {
                    Console.Write(MatrizA[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] MatrizA = new int[3, 3];

            for (int i = 0; i < MatrizA.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizA.GetLength(1); j++)
                {
                    Console.Write($"Informe a posição [linha {i}, coluna {j}]: ");
                    MatrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Informe o número desejado para multiplicar a matriz:");
            int n = int.Parse(Console.ReadLine());
            MultiplicarEscalar(MatrizA, n);
            Console.ReadLine();
        }
    }
}