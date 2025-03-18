using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis //
            int opcao;
            double cel, fah, kel;
            // do while //
            do
            {
                Console.WriteLine("=======================================");
                Console.WriteLine(" MENU DE CONVERSÃO ");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Converter de Celsius para Fahrenheit");
                Console.WriteLine("2. Converter de Celsius para Kelvin");
                Console.WriteLine("3. Converter de Fahrenheit para Celsius");
                Console.WriteLine("4. Converter de Fahrenheit para Kelvin");
                Console.WriteLine("5. Converter de Kelvin para Celsius");
                Console.WriteLine("6. Converter de Kelvin para Fahrenheit");
                Console.WriteLine("7. Sair");
                Console.WriteLine("=======================================");
                Console.WriteLine("Informe a conversão que deseja efetuar:");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("Informe o valor da temperatura em Celsius:");
                    cel = double.Parse(Console.ReadLine());
                    fah = (cel * 1.8) + 32;
                    Console.WriteLine($"A temperatura convertida para Fahrenheit é {fah}");
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Informe o valor da temperatura em Celsius");
                    cel = double.Parse(Console.ReadLine());
                    kel = cel + 273.15;
                    Console.WriteLine($"A temperatura convertida para Kelvin é {kel}");
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Informe o valor da temperatura em Fahrenheit é:");
                    fah = double.Parse(Console.ReadLine());
                    cel = (fah - 32) / 1.8;
                    Console.WriteLine($"A temperatura convertida em Celsius é: {cel}");
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Informe o valor da temperatura em Fahrenheit:");
                    fah = double.Parse(Console.ReadLine());
                    kel = (fah + 459.67) / 1.8;
                    Console.WriteLine($"A temperatura convertida em Kelvin é: {kel}");
                }
                else if (opcao == 5)
                {
                    Console.WriteLine("Informe o valor da temperatura em Kelvin:");
                    kel = double.Parse(Console.ReadLine());
                    cel = kel - 273.15;
                    Console.WriteLine($"A temperatura convertida em Celsius é: {cel}");
                }
                else if (opcao == 6)
                {
                    Console.WriteLine("Informe o valor da temperatura em Kelvin:");
                    kel = double.Parse(Console.ReadLine());
                    fah = (kel - 273.15) * 9 / 5 + 32;
                    Console.WriteLine($"A temperatura convertida em Fahrenheit é: {fah}");
                }
            }
            while (opcao != 7);
        }
    }
}