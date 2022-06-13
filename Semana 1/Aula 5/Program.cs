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
                     "3 - \n");

                Console.WriteLine("Qual é o programa que você deseja rodar");
              
                int programa = Convert.ToInt16(Console.ReadLine());
                if (programa == 1)
                {
                    string provaFinal;
                    Aluno aluno = new Aluno();
                    Console.WriteLine("Entre com a matricula do aluno");
                    aluno.matricula = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Entre o nome do aluno");
                    aluno.nome = Console.ReadLine();
                    Console.WriteLine("Entre a nota da primeia prova ");
                    aluno.prova1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Entre a nota da segunta prova");
                    aluno.prova2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Entre a nota do trabalho");
                    aluno.trab = float.Parse(Console.ReadLine());

                    Console.WriteLine($"A média do {aluno.nome} da matricula - {aluno.matricula} foi: {aluno.Media().ToString("N2")}");
                    provaFinal = (aluno.ProvaFinal() == -1) ? $"{aluno.nome} não precisa de prova final" : $"{aluno.nome} precisa de {aluno.ProvaFinal().ToString("N2")} na prova final para passar de ano";
                    Console.WriteLine(provaFinal);

                }else if(programa == 2)
                {

                }


                Console.WriteLine("Deseja executar o outro programa?");
                resposta = Console.ReadLine();

            } while (resposta == "sim");




            Console.WriteLine("Prescione enter pra sair");
            Console.Read();

        }
    }
}
