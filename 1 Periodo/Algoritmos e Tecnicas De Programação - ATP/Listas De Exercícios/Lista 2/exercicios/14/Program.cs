using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercício___14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            double h, pesoideal;
            char sexo;
            // Introdução + Leitura //
            Console.WriteLine("Informe a altura da pessoa:");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o sexo da pessoa (F para feminino) ou (M para masculino):");
        sexo = char.Parse(Console.ReadLine());
            // Calculo de altura de acordo com o sexo //
            pesoideal = (sexo == 'M') ? (72.7 * h) - 58 : (62.1 * h) - 44.7;
            Console.WriteLine($"O peso ideal é {pesoideal:f2}");
            Console.ReadLine();
        }

    }
}