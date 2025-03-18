using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_3
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo(2.3);
            Circulo c2 = new Circulo(1.5);
            Console.WriteLine("Informe o raio do circulo 3:");
            double raio = double.Parse(Console.ReadLine());
            Circulo c3 = new Circulo(raio);
            Console.WriteLine($"Circulo 1 / Area: {c1.CalcularArea()} / Diâmetro: { c1.CalcularDiametro()} / Perímetro: { c1.CalcularPerimetro()}");
                Console.WriteLine($"Circulo 2 / Area: {c2.CalcularArea()} / Diâmetro:{ c2.CalcularDiametro()} / Perímetro: { c2.CalcularPerimetro()}");
                Console.WriteLine($"Circulo 3 / Area: {c3.CalcularArea()} / Diâmetro:{ c3.CalcularDiametro()} / Perímetro: { c3.CalcularPerimetro()}");
                Console.ReadLine();
        }
    }
}