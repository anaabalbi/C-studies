using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n------------- PROGRAMAS ------------\n");
            Console.WriteLine("1 - Area do Professor \n" +
              "2 - Entrar no sistema - Login \n" +
              "3 - Banco");
            Console.Write(">");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Aluno aluno = new Aluno();
                    break;

                case "2":
                    SistemaLogin login = new SistemaLogin();
                    break;

                case "3":
                    Exercicio3();
                    break;
                
            }
           
        }
        
        static void Exercicio3()
        {
            List<ContaBancaria> contaBancarias = new List<ContaBancaria>();
            contaBancarias = new List<ContaBancaria>()
            {
                new ContaBancaria(1234567, "Ana Amelia", 1000),
                new ContaBancaria(9876543, "Jose Claudio", -50),

            };
      
            ContaBancaria conta = new ContaBancaria(0,"");
            conta.Menu(contaBancarias);

        }
}
}
