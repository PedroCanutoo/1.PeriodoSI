using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_5
{
    internal class Cargo
    {
        private int codigoCargo;
        private double valorHora;
        public Cargo(int codigoCargo, double valorHora)
        {
            this.codigoCargo = codigoCargo;
            this.valorHora = valorHora;
        }
        public double ObterValorHora()
        {
            return valorHora;
        }
        public int ObterCodigoCargo()
        {
            return codigoCargo;
        }
    }
}