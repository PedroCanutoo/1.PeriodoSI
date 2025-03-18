using System;
namespace exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            double salario, anose, salariotot, msalario, contp, mAnos, anostot, maiorsalario, contp5,
           contp15;
            double pAte5, pAte15;
            char resp;
            resp = 's';
            pAte5 = pAte15 = contp5 = contp15 = maiorsalario = mAnos = anostot = msalario = contp
           = salariotot = 0;
            // While //
            while (resp == 's' || resp == 'S')
            {
                Console.WriteLine("----------------------------------------------------");
                Console.Write("Informe o seu salário: ");
                salario = double.Parse(Console.ReadLine());
                Console.Write("Informe a quantidade de anos que você estudou: ");
                anose = double.Parse(Console.ReadLine());
                salariotot += salario;
                contp++;
                msalario = salariotot / contp;
                anostot += anose;
                mAnos = anostot / contp;
                if (salario > maiorsalario)
                {
                    maiorsalario = salario;
                }
                if (salario <= 5000.0)
                {
                    contp5++;
                }
                if (anose >= 15)
                {
                    contp15++;
                }

                if (contp > 0)
                {
                    pAte5 = (contp5 * 100.0) / contp;
                    pAte15 = (contp15 * 100.0) / contp;
                }
                else
                {
                    pAte5 = pAte15 = 0;
                }
                Console.WriteLine("---------------------------------------------------");
                Console.Write("Você quer continuar? (S para sim) ou (N para não): ");
                resp = char.Parse(Console.ReadLine());
            }
            // Exibe os resultados
            Console.WriteLine($"A média salarial da população é: {msalario}R$");
            Console.WriteLine($"A média dos anos de estudo da população é: {mAnos:F2} anos.");
            Console.WriteLine($"O maior salário presente na população é: {maiorsalario}R$");
            Console.WriteLine($"O percentual de pessoas que têm o salário até 5 mil é: { pAte5: F2}% ");
        Console.WriteLine($"O percentual de pessoas que têm 15 ou mais anos de estudo é: { pAte15: F2}% ");
        Console.ReadLine();
        }
    }
}