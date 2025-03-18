using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace exe_5
{
    internal class Program
    {
        static int Vogais(char[] letras)
        {
            int somaVogais = 0;
            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] == 'a' || letras[i] == 'e' || letras[i] == 'i' || letras[i] == 'o' || letras[i] == 'u')
                {
                    somaVogais += 1;
                }
            }
            return somaVogais;
        }
        static void Main(string[] args)
        {
            char[] letras = new char[5];
            for (int i = 0; i < letras.Length; i++)
            {
                Console.Write("Informe a letra:");
                letras[i] = char.Parse(Console.ReadLine());
            }
            int quantV = Vogais(letras);
            Console.WriteLine($"Possui: {quantV}");
            Console.ReadLine();
        }
    }
}