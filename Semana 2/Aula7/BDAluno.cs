using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    internal class BDAluno
    {
        private int matricula;
        private string nome;
        private double prova1;
        private double prova2;
        private double trab;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }

        }

        public double Trab
        {
            get { return trab; }
            set { trab = value; }

        }

        public double Prova1
        {
            get { return prova1; }
            set { prova1 = value; }
        }

        public double Prova2
        {
            get { return prova2; }
            set{  prova2 = value; }   
        }

        public BDAluno(int matricula, string nome, double prova1, double prova2, double trab)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.Prova1 = prova1;
            this.Prova2 = prova2;
            this.Trab = trab;
        }
    }
}
