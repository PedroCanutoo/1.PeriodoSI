using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int subtracao = 1;
            int contagem = 0;
            int resultado = numero;
            do
            {
                resultado -= subtracao;
                contagem++;
                subtracao += 2;
            }
            while (resultado > 0);

            Console.WriteLine($"A raiz quadrada aproximada de {numero} é {contagem - 1}");
        }
    }
}