using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_2
{
    internal class Data
    {
        private int dia;
        private int mes;
        private int ano;
        public Data(int dia, int mes, int ano)
        {
            if (dia >= 1 && dia <= 32)
            {
                this.dia = dia;
            }
            if (mes >= 1 && mes <= 12)
            {
                this.mes = mes;
            }
            if (ano > 0)
            {
                this.ano = ano;
            }
        }
        public override string ToString()
        {
            return $"Data: {dia}/{mes}/{ano}";
        }
    }
}