using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o conteúdo da string:");
            string texto = Console.ReadLine();
            Console.WriteLine("Informe o caractere que deseja verificar:");
            char carac = char.Parse(Console.ReadLine());

            texto = texto.ToLower();
            int cont = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == carac)
                {
                    cont++;
                }
            }
            Console.WriteLine($"A quantidade que o caractere{carac} aparece
           na string é: { cont}
            ");
        Console.ReadLine();
        }
    }
}