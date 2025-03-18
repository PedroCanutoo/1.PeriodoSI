using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader arq = new StreamReader("C:\\Users\\Usuario\\Downloads\\arquivo01.txt", Encoding.UTF8);
                string dados = arq.ReadLine();
                while (dados != null)
                {
                    string[] dados2 = dados.Split(';');
                    Console.WriteLine(dados2[1]);
                    dados = arq.ReadLine();
                }
                arq.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}