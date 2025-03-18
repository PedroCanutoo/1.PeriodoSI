using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis //
            int id1, id2, id3, menor, maior;
            // Impressão + leitura de idades //
            Console.WriteLine("Informe a primeira idade:");
            id1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda idade:");
            id2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira idade:");
            id3 = int.Parse(Console.ReadLine());
            maior = 0;
            menor = 1000;
            // Menor número //
            if (id1 < menor && id1 < id2 && id1 < id3)
            {
                menor = id1;
            }
            else if (id2 < menor && id2 < id1 && id2 < id3)
            {
                menor = id2;
            }
            else if (id3 < menor && id3 < id1 && id3 < id2)
            {
                menor = id3;
            }
            // Maior Número //
            if (id1 > maior && id1 > id2 && id1 > id3)
            {
                maior = id1;
            }
            else if (id2 > maior && id2 > id1 && id2 > id3)
            {
                maior = id2;
            }
            else if (id3 > maior && id3 > id1 && id3 > id2)
            {
                maior = id3;
            }
            // Impressão //
            Console.WriteLine($"O menor número informado foi: {menor}");
            Console.WriteLine($"O maior número foi: {maior}");
            Console.ReadLine();
        }
    }
}