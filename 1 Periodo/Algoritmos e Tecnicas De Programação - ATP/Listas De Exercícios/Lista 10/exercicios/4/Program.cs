using System;
using System.IO;
using System.Text;
namespace exe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader arq1 = new StreamReader("C:\\Users\\Usuario\\Downloads\\arquivo01.txt", Encoding.UTF8);
            StreamReader arq2 = new StreamReader("C:\\Users\\Usuario\\Downloads\\arquivo02.txt", Encoding.UTF8);
            string linhaIntervalo = arq2.ReadLine();
            while (linhaIntervalo != null)
            {
                string[] intervaloDados = linhaIntervalo.Split(';');
                int pesoMinimo = int.Parse(intervaloDados[0]);
                int pesoMaximo = int.Parse(intervaloDados[1]);
                Console.WriteLine($"Intervalo: {pesoMinimo} a {pesoMaximo}");
                StreamReader arq = new StreamReader("C:\\Users\\Usuario\\Downloads\\arquivo01.txt", Encoding.UTF8);
                string linhaFelino = arq.ReadLine();
                while (linhaFelino != null)
                {
                    string[] felinoDados = linhaFelino.Split(';');
                    string nomeFelino = felinoDados[0];
                    int pesoMaximoFelino = int.Parse(felinoDados[4]);
                    if (pesoMaximoFelino >= pesoMinimo && pesoMaximoFelino <= pesoMaximo)
                    {
                        Console.WriteLine(nomeFelino);
                    }
                    linhaFelino = arq.ReadLine();
                }
                arq.Close();
                linhaIntervalo = arq2.ReadLine();
                Console.WriteLine();
            }
            arq1.Close();
            arq2.Close();
            Console.ReadLine();
        }
    }
}