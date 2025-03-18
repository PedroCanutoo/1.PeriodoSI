using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace exe_5
{
    internal class Program
    {
        static bool palindromo(string texto)
        {
            texto = texto.ToLower();
            int tam = texto.Length;
            string texto2 = "";
            bool teste;
            for (int i = tam - 1; i >= 0; i--)
            {
                texto2 += texto[i];
            }
            int compara = texto.CompareTo(texto2);
            if (compara == 0)
            {
                teste = true;
            }
            else
            {
                teste = false;
            }
            return teste;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o conteúdo da string:");
            string texto = Console.ReadLine();
            Console.WriteLine(palindromo(texto));
            Console.ReadLine();
        }
    }
}