using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o conteúdo da primeira string:");
            string string1 = Console.ReadLine();
            Console.WriteLine("Informe o conteúdo da segunda string:");
            string string2 = Console.ReadLine();
            int compara = string1.CompareTo(string2);
            if (compara == 0)
            {
                Console.WriteLine("As strings são iguais!");
            }
            else
            {
                int string1tam = string1.Length;
                int string2tam = string2.Length;
                string maiorstring = "";
                if (string1tam > string2tam)
                {
                    maiorstring = string1;
                }
                else
                {
                    maiorstring = string2;
                }
                Console.WriteLine($"String de maior tamanho: {maiorstring}");
                string juncao = string1 + " " + string2;
                Console.WriteLine($"A concatenação das strings é: {juncao}");
            }
            Console.ReadLine();
        }
    }
}