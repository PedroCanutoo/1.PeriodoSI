using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_3
{
    internal class Program
    {
        static void PopularCat(StreamReader arq)
        {
            string dados = arq.ReadLine();
            while (dados != null)
            {
                string[] dados2 = dados.Split(';');
                if (int.Parse(dados2[4]) >= 10 && int.Parse(dados2[4]) <= 16)
                {
                    Console.WriteLine(dados2[0]);
                }
                dados = arq.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            StreamReader arq = new StreamReader("C:\\Users\\Usuario\\Downloads\\arquivo01.txt", Encoding.UTF8);
            PopularCat(arq);
            Console.ReadLine();
        }
    }
}