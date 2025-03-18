using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_5
{
    internal class Funcionario
    {
        private Cargo cargo;
        private char sexo;
        private double quantidadeHorasTrabalhadas;
        public Funcionario(Cargo cargo, char sexo, double quantidadeHorasTrabalhadas)
        {
            this.cargo = cargo;
            this.sexo = sexo;
            this.quantidadeHorasTrabalhadas = quantidadeHorasTrabalhadas;
        }
        public double CalcularSalario()
        {
            return cargo.ObterValorHora() * quantidadeHorasTrabalhadas;
        }
    }
}