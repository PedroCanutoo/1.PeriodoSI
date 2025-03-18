using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o conteúdo da string:");
            string frase = Console.ReadLine();
            frase = frase.ToUpper();
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'A' || frase[i] == 'E' || frase[i] == 'I' || frase[i] == 'O'
               || frase[i] == 'U')
                {
                    frase = frase.Replace($"{frase[i]}", "*");
                }
            }
            Console.WriteLine(frase);
            Console.ReadLine();
        }
    }
}