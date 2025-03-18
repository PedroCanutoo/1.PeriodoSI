using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            double menorN, maiorN, pesquisaN, somaN, mediaN, maiorM;
            int opcao = 0, selecionar = 0;
            maiorM = 0;
            mediaN = 0;
            somaN = 0;
            menorN = double.MaxValue;
            maiorN = double.MinValue;
            // Vetor //
            double[] notas = new double[5];
            for (int i = 0, cont = 1; i < notas.Length;)
            {
                Console.Write($"Informe a {cont} nota:");
                double notaentrada = double.Parse(Console.ReadLine());
                if (notaentrada >= 0 && notaentrada <= 100)
                {
                    notas[i] = notaentrada;
                    i++;
                    cont++;
                }
                else
                {
                    Console.WriteLine("Informe uma nota válida.");
                }
            }
            while (opcao != 5)
            {
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("MENU DE OPÇÕES");
                Console.WriteLine("1. Mostrar a menor nota");
                Console.WriteLine("2. Mostrar maior nota");
                Console.WriteLine("3. Pesquisar nota");
                Console.WriteLine("4. Mostrar média das notas e quantidade de notas acima da média");
               
                Console.WriteLine("5. Sair");
                Console.WriteLine("------------------------------------------------------------------");
                Console.Write("Informe a Opção:");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    for (int i = 0; i < notas.Length; i++)
                    {
                        if (notas[i] < menorN)
                        {
                            menorN = notas[i];
                        }
                    }
                    Console.WriteLine($"A menor nota foi {menorN}");
                }
                if (opcao == 2)
                {
                    for (int i = 0; i < notas.Length; i++)
                    {
                        if (notas[i] > maiorN)
                        {
                            maiorN = notas[i];
                        }
                    }
                    Console.WriteLine($"A maior nota foi {maiorN}");
                }
                if (opcao == 3)
                {
                    Console.Write("Informe a nota que deseja pesquisar:");
                    pesquisaN = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Nota pesquisada: {pesquisaN}");
                    Console.Write($"A nota consta nas posições:");
                    for (int i = 0; i < notas.Length; i++)
                    {
                        if (notas[i] == pesquisaN)
                        {
                            Console.Write(i + 1);
                            Console.Write(",");
                        }
                    }
                }
                if (opcao == 4)
                {
                    for (int i = 0; i < notas.Length; i++)
                    {
                        somaN = somaN + notas[i];
                    }
                    mediaN = somaN / notas.Length;
                    Console.WriteLine($"A média das notas foi: {mediaN}");
                    for (int i = 0; i < notas.Length; i++)
                    {
                        if (notas[i] > mediaN)
                        {
                            maiorM++;
                        }
                    }
                    Console.WriteLine($"A quantidade de notas acima da média foi: {maiorM}");
                }
            }
        }
    }
}