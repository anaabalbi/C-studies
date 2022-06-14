using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            do
            {

                Console.WriteLine("Programas \n" +
                     "1 - Aluno \n" +
                     "2 - Vôo\n" +
                     "3 - Calculadora\n");

                Console.WriteLine("Qual é o programa que você deseja rodar");
              
                int programa = Convert.ToInt16(Console.ReadLine());
                if (programa == 1)
                {
                    Aluno aluno = new Aluno();
                    aluno.Executar();

                }else if(programa == 2)
                {
                    Voo voo = new Voo();
                    voo.Executar();
                }


                Console.WriteLine("Deseja executar o outro programa?");
                resposta = Console.ReadLine();

            } while (resposta == "sim");




            Console.WriteLine("Prescione enter pra sair");
            Console.Read();

        }
    }
}
