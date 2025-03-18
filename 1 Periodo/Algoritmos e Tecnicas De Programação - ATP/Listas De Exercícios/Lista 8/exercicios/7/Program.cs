using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_7
{
    internal class Program
    {
        static int palavrasQuant(string frase)
        {
            int cont = 1;
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ')
                {
                    cont++;
                }
            }
            return cont;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o conteúdo da frase:");
            string frase = Console.ReadLine();
            Console.WriteLine($"a quantidade de palavras que tem na frase é:{palavrasQuant(frase)}");
        Console.ReadLine();
        }
    }
}