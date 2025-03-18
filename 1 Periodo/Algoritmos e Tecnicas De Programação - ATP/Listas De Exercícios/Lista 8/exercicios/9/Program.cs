using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace exe_9
{
    internal class Program
    {
        static string emailUni(string nomeCompleto)
        {
            string uni = "@acmebr.br";
            nomeCompleto = nomeCompleto.ToLower();
            string[] nomes = nomeCompleto.Split(' ');
            string primeironome = nomes[0];
            string sobrenome = " ";
            for (int i = 0; i < nomes.Length; i++)
            {
                sobrenome = nomes[i];
            }
            string email = primeironome + "." + sobrenome + uni;
            return email;
        }
        static void Main(string[] args)
        {
            // * * //
            Console.WriteLine("Informe seu nome completo:");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine(emailUni(nomeCompleto));
            Console.ReadLine();
        }
    }
}