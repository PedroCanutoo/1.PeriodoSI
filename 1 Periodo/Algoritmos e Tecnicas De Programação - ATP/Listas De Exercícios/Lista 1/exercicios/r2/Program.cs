using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercício_recomendado___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            double sm, kw, a, b;
            // Introdução + Leitura (salário min, kilowatt) //
            Console.WriteLine("-----------------------------------------------------------------");
            Console.Write("Informe o valor do salário minímo atualmente: ");
            sm = double.Parse(Console.ReadLine());
            Console.Write("Agora, informe a quantidade de kilowatt gasto pela residência: ");
            kw = double.Parse(Console.ReadLine());
            // Cálculo //
            a = sm / 1000;
            b = a * kw;
            // Tabela Final //
            Console.WriteLine("=================================================");
            Console.WriteLine($"O valor em reais de cada kilowatt é: R$ {a}");
            Console.WriteLine($"O valor em reais a ser pago é: R$ {b}");
            Console.WriteLine("=============================================");
            Console.ReadLine();
        }
    }
}