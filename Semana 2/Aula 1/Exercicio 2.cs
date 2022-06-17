using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6
{
    internal class Empregado
    {
        public string name;
        public string cargo;
        private double salario;

        private double Salario
        {
            get { return this.salario; }
            set {
                if (this.salario < 0)
                {
                    this.salario = 0.0;
                }
            }
        }
        

        public Empregado(string name, string cargo, double salario)
        {
            this.name = name;
            this.cargo = cargo;
            this.Salario = salario;
        }

       

        public void MostraSalario() 
        { 
               Console.WriteLine($"O salário atualizado do {this.name} é: {(this.salario).ToString("N2")}");
        }

        public void Aumento()
        {
            
            if (this.salario <= 400)
            {
               
               this.salario= this.salario * 1.15;
            }
            else if (this.salario <= 800)
            {
                
                this.salario=this.salario * 1.12;
            }
            else if (this.salario <= 1200)
            {
                
                this.salario = salario * 1.10;
            }
            else if (this.salario <= 2000)
            {
                
                this.salario = this. salario * 1.07;
            }
            else
            {
                
                this.salario = this.salario * 1.04;
            }
        }
    }
}
