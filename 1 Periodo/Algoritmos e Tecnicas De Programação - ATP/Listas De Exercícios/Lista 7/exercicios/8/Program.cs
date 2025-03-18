using System;
namespace SomaSequencia
{
    internal class Program
    {
        static double CalcularSoma(int n)
        {
            double soma = 0.0;

            for (int i = 1; i <= n; i++)
            {
                double numerador = (i * i) + 1;
                double denominador = i + 3;
                soma += numerador / denominador;
            }
            return soma;
        }
        static void Main(string[] args)
        {
            Console.Write("Informe o valor:");
            int n = int.Parse(Console.ReadLine());
            double resultado = CalcularSoma(n);
            Console.WriteLine($"A soma S para n = {n} é: {resultado}");
            Console.ReadLine();
        }
    }
}