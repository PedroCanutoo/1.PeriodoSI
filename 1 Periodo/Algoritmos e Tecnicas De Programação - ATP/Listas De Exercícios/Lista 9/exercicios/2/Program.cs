using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_2
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeira data");
            Console.WriteLine("Informe o dia:");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o mês:");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o ano:");
            int ano = int.Parse(Console.ReadLine());
            Data d1 = new Data(dia, mes, ano);
            Console.WriteLine($"Primeira data: {d1}");
            Data d2 = new Data(18, 11, 2024);
            Console.WriteLine($"Segunda data: {d2}");
            Console.ReadLine();
        }
    }
}