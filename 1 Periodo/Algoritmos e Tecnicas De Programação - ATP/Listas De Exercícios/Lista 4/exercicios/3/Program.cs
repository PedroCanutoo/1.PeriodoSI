using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis /
            double kwh, pkwh, total, maiorkwh, menorkwh, mediakwh, constotal, soma;
            menorkwh = double.MaxValue;
            maiorkwh = -1;
            total = 0;
            // Leitura de dados //
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Informe o preço do kwh:");
                pkwh = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe a quantidade consumida de kwh:");
                kwh = double.Parse(Console.ReadLine());
                soma = pkwh * kwh;
                if (kwh > maiorkwh)
                {
                    maiorkwh = kwh;
                }
                if (kwh < menorkwh)
                {
                    menorkwh = kwh;
                }
                total = total + soma;
                Console.WriteLine($"O valor total a ser pago foi {total}");
            }
            mediakwh = total / 3;
            Console.WriteLine($"O maior consumo verificado foi: {maiorkwh:f2}");
            Console.WriteLine($"O menor consumo verificado foi: {menorkwh:f2}");
            Console.WriteLine($"O consumo médio foi: {mediakwh:f2}");
            Console.ReadLine();
        }
    }
}