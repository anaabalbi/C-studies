using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5
{
    internal class Calculadora
    {
        public string number1="";
        public string number2="";
        public string expressao;

        public void Executar()
        {
            Console.WriteLine("------------------- CALCULDORA -----------------------");
            Console.WriteLine("Calcule soma (+), subtração(-), divisão(/) e multiplicação(*)");
            Console.WriteLine("Entre com a expressão a ser calculada. Ex: 2+2");
            expressao=Console.ReadLine();
       
            if (expressao.IndexOf("+") > 0)
            {
                for(int i=0; i< expressao.IndexOf("+"); i++)
                {
                    number1 = number1+expressao[i];
                }
                for (int i = expressao.IndexOf("+")+1; i < expressao.Length; i++)
                {
                    number2 = number2 + expressao[i];
                }
                Soma(number1, number2);
            } else if(expressao.IndexOf("-") > 0)
            {
                for (int i = 0; i < expressao.IndexOf("-"); i++)
                {
                    number1 = number1 + expressao[i];
                }
                for (int i = expressao.IndexOf("-") + 1; i < expressao.Length; i++)
                {
                    number2 = number2 + expressao[i];
                }
                Subtracao(number1, number2);

            } else if(expressao.IndexOf("*") >0){
                for (int i = 0; i < expressao.IndexOf("*"); i++)
                {
                    number1 = number1 + expressao[i];
                }
                for (int i = expressao.IndexOf("*") + 1; i < expressao.Length; i++)
                {
                    number2 = number2 + expressao[i];
                }
                Multiplicacao(number1, number2);
            }
            else
            {
                for (int i = 0; i < expressao.IndexOf("+"); i++)
                {
                    number1 = number1 + expressao[i];
                }
                for (int i = expressao.IndexOf("+") + 1; i < expressao.Length; i++)
                {
                    number2 = number2 + expressao[i];
                }
                Divisao(number1, number2);

            }

        }

        public void Soma(string number1, string number2) { 
            Console.WriteLine($"{number2} + {number2} = {float.Parse(number2)+float.Parse(number1)}");
        }

        public void Subtracao(string number1, string number2)
        {
            Console.WriteLine($"{number2} - {number2} = {float.Parse(number2) - float.Parse(number1)}");
        }

        public void Multiplicacao(string number1, string number2)
        {
            Console.WriteLine($"{number2} * {number2} = {float.Parse(number2) * float.Parse(number1)}");
        }
        public void Divisao(string number1, string number2)
        {
            Console.WriteLine($"{number2} / {number2} = {float.Parse(number2) / float.Parse(number1)}");
        }
    }
}
