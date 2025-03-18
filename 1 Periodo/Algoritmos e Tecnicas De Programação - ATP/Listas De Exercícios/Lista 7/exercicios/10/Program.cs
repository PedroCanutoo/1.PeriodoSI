using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_10
{
    internal class Program
    {
        static void comparacao(int[] vet1, int[] vet2)
        {
            int[] vet3 = new int[5];
            for (int i = 0; i < vet3.Length; i++)
            {
                if (vet1[i] == vet2[i])
                {
                    vet3[i] = vet1[i];
                }
            }
            Console.WriteLine("Comparação de matrícula:");
            for (int i = 0; i < vet3.Length; i++)
            {
                Console.Write(vet3[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] vet1 = new int[3];
            for (int i = 0; i < vet1.Length; i++)
            {
                Console.WriteLine($"Informe o número de matricula {i} do vetor1:");
                vet1[i] = int.Parse(Console.ReadLine());
            }
            int[] vet2 = new int[3];
            for (int i = 0; i < vet2.Length; i++)
            {
                Console.WriteLine($"Informe o número de matricula {i} do vetor1:");
                vet2[i] = int.Parse(Console.ReadLine());
            }
            comparacao(vet1, vet2);
            Console.ReadLine();
        }
    }
}