using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
namespace exercício_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DV //
            double nota, notatot, media;
            int alunos;
            nota = notatot = alunos = 0;
            media = 0;

            // While //
            while (nota >= 0)
            {
                Console.WriteLine("Informe a nota do aluno:");
                nota = double.Parse(Console.ReadLine());
                if (nota >= 0)
                {
                    alunos++;
                    notatot = notatot + nota;
                    media = notatot / alunos;
                }
            }
            Console.WriteLine($"A média das notas deu um total de: {media}");
            Console.ReadLine();
        }
    }
}