using System;
using System.IO;
using System.Text;
namespace exe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader arq1 = new StreamReader("C:\\Users\\Usuario\\Downloads\\arquivo01.txt", Encoding.UTF8);
            StreamReader arq2 = new StreamReader("C:\\Users\\Usuario\\Downloads\\arquivo02.txt", Encoding.UTF8);
            StreamWriter arq3 = new StreamWriter("C:\\Users\\Usuario\\Downloads\\arquivo03.txt", false, Encoding.UTF8);
            string lInt = arq2.ReadLine();
            while (lInt != null)
            {
                string[] intervaloDados = lInt.Split(';');
                int pesoMinimo = int.Parse(intervaloDados[0]);
                int pesoMaximo = int.Parse(intervaloDados[1]);
                Console.WriteLine($"Intervalo: {pesoMinimo} a {pesoMaximo}");
                arq3.WriteLine($"Intervalo: {pesoMinimo} a {pesoMaximo}");
                StreamReader arq1Temp = new
               StreamReader("C:\\Users\\Usuario\\Downloads\\arquivo-01.txt", Encoding.UTF8);
                string lFelino = arq1Temp.ReadLine();
                while (lFelino != null)
                {
                    string[] felinoDados = lFelino.Split(';');
                    string nFelino = felinoDados[0];
                    int pesoMaximoFelino = int.Parse(felinoDados[4]);

                    if (pesoMaximoFelino >= pesoMinimo && pesoMaximoFelino <= pesoMaximo)
                    {
                        Console.WriteLine(nFelino);
                        arq3.WriteLine(nFelino);
                    }
                    lFelino = arq1Temp.ReadLine();
                }
                arq1Temp.Close();
                lInt = arq2.ReadLine();
                Console.WriteLine();
                arq3.WriteLine();
            }
            arq1.Close();
            arq2.Close();
            arq3.Close();
            Console.ReadLine();
        }
    }
}