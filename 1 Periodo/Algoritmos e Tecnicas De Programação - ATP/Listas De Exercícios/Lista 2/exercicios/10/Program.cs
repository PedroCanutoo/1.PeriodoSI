using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício___10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarãção de Variáveis //
            int dia;
            // Introdução + Leitura de Dados //
            Console.Write("Informe um número entre 1 e 7:");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------");
            // Switch //

             switch (dia)
            {
                case 1:
                    Console.WriteLine("O número 1 é correspondente ao dia DOMINGO.");
                    break;
                case 2:
                    Console.WriteLine("O número 2 é correspondente ao dia SEGUNDAFEIRA.");
                    break;
                case 3:
                    Console.WriteLine("O número 3 é correspondente ao dia TERÇA-FEIRA.");
                    break;
                case 4:
                    Console.WriteLine("O número 4 é correspondente ao dia QUARTA-FEIRA.");
                    break;
                case 5:
                    Console.WriteLine("O número 5 é correspondente ao dia QUINTA-FEIRA.");
                    break;
                case 6:
                    Console.WriteLine("O número 6 é correspondente ao dia SEXTA-FEIRA.");
                    break;
                case 7:
                    Console.WriteLine("O número 7 é correspondente ao dia SÁBADO.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.ReadLine();
        }
    }
}