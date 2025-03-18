using System;
using System.IO;
using System.Text;
namespace exe_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tHD = 53687091200;
            double totalUsado = 0;
            StreamReader entrada = new
           StreamReader("C:\\Users\\Usuario\\Downloads\\usuarios.txt", Encoding.UTF8);
            StreamWriter saida = new
           StreamWriter("C:\\Users\\Usuario\\Downloads\\relatório.txt", false, Encoding.UTF8);
            string linha = entrada.ReadLine();
            while (linha != null)
            {
                string[] dados = linha.Split('/');
                string nome = dados[0];
                double usado = double.Parse(dados[1]);
                double pct = (usado / totalUsado) * 100;
                saida.WriteLine($"{nome}/{pct:F2}%");
                totalUsado += usado;
                linha = entrada.ReadLine();
            }
            double pctTotal = (totalUsado / tHD) * 100;
            saida.WriteLine();
            saida.WriteLine($"Total: {totalUsado} bytes");
            saida.WriteLine($"Percentual: {pctTotal:F2}%");
            entrada.Close();
            saida.Close();
            Console.ReadLine();
        }
    }
}