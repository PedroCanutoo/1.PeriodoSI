using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_4
{
    internal class Aluno
    {
        private string nome;
        private string matricula;
        private double[] notas = new double[10];
        public Aluno(string nome, string matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }
        public void SetNota(int indice, double nota)
        {
            if (indice >= 0 && indice < 10)
            {
                notas[indice] = nota;
            }
        }
        public double MediaNotas()
        {
            double somaN = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                somaN += notas[i];
            }
            double mediaN = somaN / notas.Length;
            return mediaN;
        }
        public string Nome()
        {
            return nome;
        }
        public string Matricula()
        {
            return matricula;
        }
    }
}