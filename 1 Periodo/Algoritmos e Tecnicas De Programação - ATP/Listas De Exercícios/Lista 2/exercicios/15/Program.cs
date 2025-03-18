using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace exercício___15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            int ano;
            // Introdução + Leitura //
            Console.WriteLine("Informe um ANO e o programa avaliará se é ou não um ano bissexto: ");
           
            ano = int.Parse(Console.ReadLine());
            // Verificação //
            string resultado = ((ano % 4 == 0 && ano % 100 != 0))
            ? "É bissexto."
            : "Não é bissexto.";
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}