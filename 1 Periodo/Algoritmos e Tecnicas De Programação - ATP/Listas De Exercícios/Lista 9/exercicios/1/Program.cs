using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
namespace exe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Pedro Canuto", "38-999351545", "Rua zumiro ramos de almeida");
            Cliente c2 = new Cliente("André Canuto", "Rua Valmira Pires");
            Cliente c3 = new Cliente("Adalmo Canuto", "38-99670050", "Rua Nações Unidas");
            Console.WriteLine($"Cliente 1: {c1.Nome}, {c1.Telefone}, {c1.Endereco}");
            Console.WriteLine($"Cliente 2: {c2.Nome}, {c2.Endereco}");
            Console.WriteLine($"Cliente 3: {c3.Nome}, {c3.Telefone}, {c3.Endereco}");
            Console.ReadLine();
        }
    }
}