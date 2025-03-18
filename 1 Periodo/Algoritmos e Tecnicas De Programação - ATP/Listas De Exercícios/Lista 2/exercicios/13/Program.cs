using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício___13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            char l;
            // Introdudção + Leitura //
            Console.WriteLine("Informe uma letra e o programa informará se ela é uma VOGAL ou CONSOANTE: ");
           
            l = char.Parse(Console.ReadLine());
            // Switch //
            switch (l)
            {
                case 'A':
                case 'a':
                case 'E':
                case 'e':
                case 'I':
                case 'i':
                case 'O':
                case 'o':
                case 'U':
                case 'u':
                    Console.WriteLine("A letra informada é uma VOGAL!");
                    break;
                default:
                    Console.WriteLine("A letra informada é uma CONSOANTE!");
                    break;
            }
            Console.ReadLine();
        }
    }
}