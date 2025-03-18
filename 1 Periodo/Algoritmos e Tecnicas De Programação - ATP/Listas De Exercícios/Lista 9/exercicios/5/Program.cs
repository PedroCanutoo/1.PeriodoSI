using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_5
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            Cargo cargo1 = new Cargo(101, 50.0);
            Cargo cargo2 = new Cargo(102, 70.0);
            Cargo cargo3 = new Cargo(103, 90.0);
            Funcionario funcionario1 = new Funcionario(cargo1, 'M', 160);
            Funcionario funcionario2 = new Funcionario(cargo2, 'F', 150);
            Funcionario funcionario3 = new Funcionario(cargo3, 'M', 170);
            Console.WriteLine("Salário do f1 Cargo: " + cargo1.ObterCodigoCargo() + ":" +
           funcionario1.CalcularSalario());
            Console.WriteLine("Salário do f2 Cargo: " + cargo2.ObterCodigoCargo() + ":" +
           funcionario2.CalcularSalario());
            Console.WriteLine("Salário do f3Cargo: " + cargo3.ObterCodigoCargo() + ":" +
           funcionario3.CalcularSalario());
            Console.ReadLine();
        }
    }
}