using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] candidatos = { "Perna Longa", "Pluto", "Mickey", "Bob Esponja", "Cebolinha" };
            int[] votos = new int[5];
            int votosNulos = 0;

            Console.WriteLine("Digite até 100 votos (0 a 4 para candidatos):");
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"Voto {i + 1}: ");
                int voto = Convert.ToInt32(Console.ReadLine());
                if (voto >= 0 && voto <= 4)
                {
                    votos[voto]++;
                }
                else
                {
                    votosNulos++;
                }
            }

            int maisVotado = 0;
            int menosVotado = 0;
            for (int i = 1; i < votos.Length; i++)
            {
                if (votos[i] > votos[maisVotado])
                {
                    maisVotado = i;
                }
                if (votos[i] < votos[menosVotado])
                {
                    menosVotado = i;
                }
            }
            // Exibindo os resultados
            Console.WriteLine("\nResultados da votação:");
            Console.WriteLine($"Candidato mais votado: {candidatos[maisVotado]} com {votos[maisVotado]} votos.");
        Console.WriteLine($"Candidato menos votado: {candidatos[menosVotado]} com{votos[menosVotado]}votos.");
        Console.WriteLine($"Quantidade de votos nulos: {votosNulos}");
        }
    }
}