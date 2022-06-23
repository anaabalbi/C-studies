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
              "3 - Banco\n" +
              "4 - PetShop");
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
                    ContaBancaria conta = new ContaBancaria();
                    break;
                case "4":
                    PetShop pet = new PetShop(); 
                    break;
                case "5":
                    break;
                default:
                    Main(args);
                    break;

            }

        }
     


    }
}
