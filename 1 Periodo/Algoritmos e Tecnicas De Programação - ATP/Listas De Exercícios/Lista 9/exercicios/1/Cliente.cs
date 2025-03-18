using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exe_1
{
    internal class Cliente
    {
        private string nome;
        private string endereco;
        private string telefone;
        public Cliente(string nome, string endereco, string telefone)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
        }
        public Cliente(string nome, string endereco)
        {
            this.nome = nome;
            this.endereco = endereco;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}