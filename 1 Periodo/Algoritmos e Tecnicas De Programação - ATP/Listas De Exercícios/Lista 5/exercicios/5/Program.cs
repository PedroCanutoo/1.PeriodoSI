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
            double[] notas = new double[60];
            int quantidadeNotas = 0;

            Console.WriteLine("Digite as notas dos alunos (digite um valor negativo para terminar):");
        while (quantidadeNotas < 60)
            {
                Console.Write($"Nota do aluno {quantidadeNotas + 1}: ");
                double nota = Convert.ToDouble(Console.ReadLine());

                if (nota >= 0)
                {
                    notas[quantidadeNotas] = nota;
                    quantidadeNotas++;
                }
                else
                {
                    quantidadeNotas = 60;
                }
            }

            if (quantidadeNotas > 0)
            {

                double soma = 0;
                for (int i = 0; i < quantidadeNotas; i++)
                {
                    soma += notas[i];
                }
                double media = soma / quantidadeNotas;

                Console.WriteLine("Notas dos alunos:");
                for (int i = 0; i < quantidadeNotas; i++)
                {
                    Console.WriteLine(notas[i]);
                }

                Console.WriteLine("Notas acima da média:");
                for (int i = 0; i < quantidadeNotas; i++)
                {
                    if (notas[i] > media)
                    {
                        Console.WriteLine(notas[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Nenhuma nota foi registrada.");
            }
        }
    }
}