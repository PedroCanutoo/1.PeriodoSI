using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace exercício___7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis //
            double dist, peso;
            double pkm, pfm, pfv, pfc, seguro;
            string urg;
            // Impressão + Leitura //
            Console.Write("Informe a distância em KM:");
            dist = double.Parse(Console.ReadLine());
            Console.Write("Informe o peso em KG:");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrega urgente? (aumenta em 30% o preço do frete com Moto, 70 % com Van e 100 % com Caminhão");
           
            Console.Write("para entrega urgente digite (sim), entrega sem urgência digite (nao):");
           
            urg = Console.ReadLine();
            pfm = 0;
            pkm = 1;
            seguro = pkm + (pkm / 100 * 20);
            Console.WriteLine("------------------------------------------------------------------------------------------------- - ");
        // MOTO //
            if (dist > 5 || peso > 20)
            {
                Console.WriteLine("A opção MOTO não está disponível.");
            }
            else if (dist <= 5 && peso <= 20)
            {
                if (urg == "sim")
                {
                    pkm = pkm + seguro;
                    pfm = (pkm * dist);
                    pfm = pfm + (pfm / 100 * 30);
                    Console.WriteLine($"O valor do frete caso, a entrega seja feita deMOTO será: {pfm}");
                }
                else if (urg == "nao")
                {
                    pkm = pkm + (pkm / 100 * 20);
                    pfm = pfm + seguro;
                    Console.WriteLine($"O valor do frete caso, a entrega seja feita de MOTO será: {pfm}");
                }
            }
            // VAN //
            if (peso > 1000)
            {
                Console.WriteLine("A opção VAN não está disponível.");
            }
            else if (peso <= 1000)
            {
                if (urg == "sim")
                {
                    pfv = (pkm * dist);
                    pfv = pfv + (pfv / 100 * 70);
                    Console.WriteLine($"O valor do frete, caso a entrega seja feita de VAN será: {pfv}");
                }
                else if (urg == "nao")
                {
                    pfv = (pkm * dist);
                    Console.WriteLine($"O valor do frete, caso a entrega seja feita de VAN será: { pfv}");
                }
            }
            // CAMINHAO //
            if (urg == "sim")
            {
                pfc = (pkm * dist);
                pfc = pfc + (pfc);
                Console.WriteLine($"O valor do frete, caso a entrega seja feita de CAMINHÃO será: { pfc}");
            }
            else if (urg == "nao")
            {
                pfc = (pkm * dist);
                Console.WriteLine($"O valor do frete, caso a entrega seja feita de CAMINHÃO será: { pfc}");
            }

            Console.ReadLine();
        }
    }
}