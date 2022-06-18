using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6
{
    internal class Fatura
    {
        private int numero;
        private  string descricao = String.Empty;
        private int quatidade;
        private double preco;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
        public int Quantidade
        {
            get { return this.quatidade; }
            set { this.quatidade = value; }
        }
        public double Preco
        {
            get { return this.preco ; }
            set { this.preco = value; }
        }


        public Fatura(int numero, string descricao, int quantidade, double preco)
        {
            this.Numero = numero;
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.Preco= preco;
        }

        public void ValorFatura()
        {
            Console.WriteLine($"O valor da fatura ficou em: R${(this.quatidade * this.preco).ToString("N2")}");
        }
        
    }
}
