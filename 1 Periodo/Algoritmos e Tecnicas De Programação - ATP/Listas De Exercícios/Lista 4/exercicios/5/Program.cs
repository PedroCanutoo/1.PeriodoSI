using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
namespace exe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            int cand1, cand2, cand3, branco, nulo, voto, maisvot;
            char result;
            maisvot = branco = nulo = cand1 = cand2 = cand3 = 0;
            // do while //
            do
            {
                Console.WriteLine("Informe seu voto [1 para candidato 1 / 2 para candidato 2 / 3 para candidato 3 / 4 para branco / qualquer outro valor para nulo: ");
               
                voto = int.Parse(Console.ReadLine());
                if (voto == 1)
                {
                    cand1++;
                }
                else if (voto == 2)
                {
                    cand2++;
                }
                else if (voto == 3)
                {
                    cand3++;
                }
                else if (voto == 4)
                {
                    branco++;
                }
                else
                {
                    nulo++;
                }
                if (cand1 > cand2 && cand1 > cand3)
                {
                    maisvot = 1;
                }
                else if (cand2 > cand1 && cand2 > cand3)
                {
                    maisvot = 2;
                }
                else if (cand3 > cand1 && cand3 > cand2)
                {
                    maisvot = 3;
                }
                Console.WriteLine("Quer continuar? [s] para sim OU [n] para não:");
                result = char.Parse(Console.ReadLine());

            }
            while (result == 's');
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"O candidato 1 recebeu {cand1} votos:");
            Console.WriteLine($"O candidato 2 recebeu {cand2} votos:");
            Console.WriteLine($"O candidato 3 recebeu {cand3} votos:");
            Console.WriteLine($"O código do candidato mais votado {maisvot}");
            Console.WriteLine($"Total de votos nulos: {nulo}");
            Console.WriteLine($"Total de votos brancos: {branco}");
            Console.ReadLine();
        }
    }
}