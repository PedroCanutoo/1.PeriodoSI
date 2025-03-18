using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace exe_2
{
    internal class Program
    {
        static void PesoMedia(StreamReader arq)
        {
            string dados = arq.ReadLine();
            int maior = int.MinValue;
            int menor = int.MaxValue;
            int soma = 0;
            while (dados != null)
            {
                string[] dados2 = dados.Split(';');
                if (maior < int.Parse(dados2[3]))
                {
                    maior = int.Parse(dados2[3]);
                }
                if (int.Parse(dados2[3]) < menor)
                {
                    menor = int.Parse(dados2[3]);
                }
                soma += int.Parse(dados2[3]);
                dados = arq.ReadLine();
            }
            double media = soma / 9;
            Console.WriteLine($"Maior peso: {maior}");
            Console.WriteLine($"Menor peso: {menor}");
            Console.WriteLine($"Média das notas: {media}");
        }
        static void Main(string[] args)
        {
            StreamReader arq = new StreamReader("C:\\Users\\Usuario\\Downloads\\arquivo01.txt", Encoding.UTF8);
            PesoMedia(arq);
            Console.ReadLine();
        }
    }
}