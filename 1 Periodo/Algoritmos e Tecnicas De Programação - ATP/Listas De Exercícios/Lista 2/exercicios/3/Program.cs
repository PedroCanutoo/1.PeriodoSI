using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício___3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            int id, tempoH;
            char tipoH;
            // Impressão + leitura de idade, tipo de habilitação e tempo habilitado //
            Console.WriteLine("Informe a sua idade:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o tipo da sua habilitação em letra maiúscula(A, B, C):");
        tipoH = char.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantos anos você possuí habilitação:");
            tempoH = int.Parse(Console.ReadLine());
            // Verificação PERMITIDO //
            if (id >= 21 && tipoH == 'B' && tempoH >= 2)
            {
                Console.WriteLine("Você possuí os requisitos necessários para tirar a habilitação D");
            }
            else if (id >= 21 && tipoH == 'C' && tempoH >= 1)
            {
                Console.WriteLine("Você possuí os requisitos necessários para tirar a habilitação D");
            }
            // Verificação NÃO PERMITIDO //

            if (tipoH == 'A')
            {
                Console.WriteLine("O seu tipo de habilitação não permite com que você tire a habilitação D.");
            }
            if (id < 21)
            {
                Console.WriteLine("Você não tem idade o suficiente para ter HABILITAÇÃO D");
            }
            if (tipoH == 'B' && tempoH < 2)
            {
                Console.WriteLine("Você não tem o tempo minímo de habilitação B para tirar a habilitação D.");
            }
            if (tipoH == 'C' && tempoH < 1)
            {
                Console.WriteLine("Você não tem o tempo minímo de habilitação C para tirar a habilitação D.");
            }

            Console.ReadLine();

        }
    }
}