using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace exe_3
{
    internal class Program
    {
        static (int Vogais, int Consoantes) numVeC(string texto)
        {
            texto = texto.ToLower();
            int contV = 0;
            int contC = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != 'a' && texto[i] != 'e' && texto[i] != 'i' && texto[i] !=
               'o' && texto[i] != 'u')
                {
                    contC++;
                }
                else
                {
                    contV++;
                }
            }
            return (contV, contC);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o contúdo da string:");
            string texto = Console.ReadLine();
            Console.WriteLine(numVeC(texto));
            Console.ReadLine();
        }
    }
}