using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
namespace exe_3
{
    internal class Circulo
    {
        private double raio;
        public Circulo(double raio)
        {
            this.raio = raio;
        }
        public double CalcularArea()
        {
            double area = Math.Pow(raio, 2) * 3.14;
            return area;
        }
        public double CalcularDiametro()
        {
            double diametro = raio * 2;
            return diametro;
        }
        public double CalcularPerimetro()
        {
            double perimetro = 2 * 3.14 * raio;
            return perimetro;
        }
    }
}