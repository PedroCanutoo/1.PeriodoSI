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
            Console.WriteLine("Informe o conteúdo da string:");
            string texto = Console.ReadLine();
            int tam = texto.Length;
            for (int i = tam - 1; i >= 0; i--)
            {
                Console.Write(texto[i]);
            }
            Console.ReadLine();
        }
    }
}