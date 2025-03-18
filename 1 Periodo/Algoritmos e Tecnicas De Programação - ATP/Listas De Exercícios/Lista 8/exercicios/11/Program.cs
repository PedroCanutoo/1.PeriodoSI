using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
namespace exe_11
{
    internal class Program
    {
        static string[,] MatrizDados(string csv)
        {
            string[,] matriz = new string[4, 3];
            string[] dados = csv.Split(',');
            int posdados = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = dados[posdados];
                    posdados++;
                }
            }
            return matriz;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados, separados por vírgula:");
            string csv = Console.ReadLine();
            Console.ReadLine();
            /* Está certo, mas não consigo imprimir a matriz usando o retorno
           (para conferir teria que imprimir dentro do método e ficar void) */
        }
    }
}