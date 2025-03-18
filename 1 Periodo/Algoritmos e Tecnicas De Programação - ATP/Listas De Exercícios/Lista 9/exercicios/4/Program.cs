using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_4
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Pedro Canuto", "1");
            Aluno a2 = new Aluno("Ana", "2");
            Console.WriteLine("Preencha as notas do:" + a1.Nome());
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nota {i + 1}: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                a1.SetNota(i, nota);
            }
            Console.WriteLine("Preencha as notas do:" + a2.Nome());
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nota {i + 1}: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                a2.SetNota(i, nota);
            }
            Console.WriteLine("Média do aluno " + a1.Nome() + " (" + a1.Matricula() + "): " +
           a1.MediaNotas());
            Console.WriteLine("Média do aluno " + a2.Nome() + " (" + a2.Matricula() + "): " +
           a2.MediaNotas());
            Console.ReadLine();
        }
    }
}