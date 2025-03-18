using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente[] clientes = new Cliente[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Cadastro do Cliente {i + 1}:");
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o endereço: ");
                string endereco = Console.ReadLine();
                Console.Write("Digite o telefone: ");
                string telefone = Console.ReadLine();
                clientes[i] = new Cliente(nome, endereco, telefone);
            }
            clientes[0].Nome = "Pedro Canuto";
            Console.WriteLine("Dados dos Clientes:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(clientes[i].ToString());
            }
        }
    }
}