using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_9
{
    internal class Program
    {
        static void ObterMaiorMenor(float[] vet, out float menor, out float maior)
        {
            float maiornum = float.MinValue;
            float menornum = float.MaxValue;

            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] > maiornum)
                {
                    maiornum = vet[i];
                }
                if (vet[i] < menornum)
                {
                    menornum = vet[i];
                }
            }
            maior = maiornum;
            menor = menornum;
        }
        static void Main(string[] args)
        {
            float[] numeros = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f };
            ObterMaiorMenor(numeros, out float menor, out float maior);
            Console.WriteLine($"O maior número do vetor é: {maior}");
            Console.WriteLine($"O menor número do vetor é: {menor}");
            Console.ReadLine();
        }
    }
}