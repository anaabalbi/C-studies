using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    internal class ContaBancaria 
    {
        private int conta;
        private string nome;
        private double saldo;
        public int Conta
        {
            get { return conta; }
            set { conta = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }   
        }

        public ContaBancaria(int conta, string nome, double saldo=0)
        {
            this.Conta = conta;
            this.Nome = nome;
            this.Saldo = saldo;
          
        }

        public void Menu(List<ContaBancaria> contas)
        {
   
            Console.Clear();
            Console.WriteLine("\n------------- ACESSO A CONTA BANCARIA --------\n");
            Console.WriteLine("1 - Deposito \n" +
              "2 - Saque \n" +
              "3 - Alterar nome \n" +
              "4 - Cadastrar conta \n");

            Console.Write(">");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Depositar(contas);
                    break;

                case "2":
                    Console.Clear();
                    Sacar(contas);
                    break;

                case "3":
                    Alterar(contas);
                    break;
                case "4":
                    NovaConta(contas);
                    break;
                default:
                    Menu(contas);
                    Console.WriteLine("Pressione ENTER para sair...");
                    Console.Read();
                    break;
            }

          
        }

        private int AcessarConta(int contaCorrente, List<ContaBancaria> contas)
        {
            int resposta = -1;
            for (int i = 0; i < contas.Count; i++)
            {
                if (contas[i].Conta == contaCorrente)
                {
                    resposta = i;
                    break;

                }
            }
            return resposta;
        }
        private void Depositar(List<ContaBancaria> contas)
        {
            Console.Clear();
            Console.WriteLine("\nEntre com o número da conta que deseja Depositar");
            int contaCorrente = int.Parse(Console.ReadLine());
            int i=AcessarConta(contaCorrente, contas);
            if (i < 0)
            {
                Console.Clear();
                Console.WriteLine("\nConta não encontrada, tente novamente\n");
                Menu(contas);

            }
            else
            {
              
                Console.WriteLine("\nEntre com o valor do deposito");
                double deposito = double.Parse(Console.ReadLine());
                contas[i].Saldo = contas[i].Saldo + deposito;
                Console.WriteLine("Deposito realizado com sucesso!");
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Conta: {contas[i].Conta} \n" +
                    $"Nome: {contas[i].Nome}\n" +
                    $"Valor: R${deposito}");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Deseja realizar outra operação?");
                string resposta = Console.ReadLine();
                if (resposta != "sim")
                {
                    Console.Read();
                }
                else
                {
                    Menu(contas);
                }
            }


        }

        private void Sacar(List<ContaBancaria> contas)
        {
            Console.Clear();
            Console.WriteLine("\nEntre com o número da conta que deseja Sacar");
            int contaCorrente = int.Parse(Console.ReadLine());
            int i = AcessarConta(contaCorrente, contas);
            if (i < 0)
            {
                Console.Clear();
                Console.WriteLine("\nConta não encontrada, tente novamente\n");
                Menu(contas);

            }
            else
            {
               
                Console.WriteLine("\nEntre com o valor do saque");
                double saque = double.Parse(Console.ReadLine());
                ConsultaSaque(contas, saque, i);       
                Console.WriteLine("Deseja realizar outra operação?");
                string resposta = Console.ReadLine();
                if (resposta != "sim")
                {
                    Console.Read();
                }
                else
                {
                    Menu(contas);
                }
            }

        }

        private void ConsultaSaque(List<ContaBancaria> contas, double saque, int i)
        {
            if (saque <= contas[i].Saldo)
            {
                contas[i].Saldo = contas[i].Saldo - saque;
                Console.WriteLine("Saque realizado com sucesso!");
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Conta: {contas[i].Conta} \n" +
                    $"Nome: {contas[i].Nome}\n" +
                    $"Valor: R${saque}\n+" +
                    $"Saldo atual: R${contas[i].Saldo}");
                Console.WriteLine("---------------------------------");
            }
            else
            {
                Console.WriteLine("O saque não realizado. Valor do saque maior que o disponível");
            }
        }

        private void Alterar(List<ContaBancaria> contas)
        {
            Console.Clear();
            Console.WriteLine("\nEntre com o número da conta que deseja alterar o nome");
            int contaCorrente = int.Parse(Console.ReadLine());
            int i = AcessarConta(contaCorrente, contas);
            if (i < 0)
            {
                Console.Clear();
                Console.WriteLine("\nConta não encontrada, tente novamente\n");
                Menu(contas);

            }
            else
            {
                
                Console.WriteLine("\nEntre com o novo nome");
                string novoNome = Console.ReadLine();
                contas[i].Nome = novoNome;
                Console.WriteLine("Nome trocado com sucesso!");
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Conta: {contas[i].Conta} \n" +
                    $"Nome: {contas[i].Nome}");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Deseja realizar outra operação?");
                string resposta = Console.ReadLine();
                if (resposta != "sim")
                {
                    Console.Read();
                }
                else
                {
                    Menu(contas);
                }

            }
        }
      
        private void NovaConta(List<ContaBancaria> contas)
        {
            Console.Clear();
            Console.WriteLine("\nEntre com o número da conta:");
            Conta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Deseja realizar o primeiro deposito?");
            string resposta = Console.ReadLine();
            if (resposta != "sim")
            {
                Console.Clear();
                contas.Add(new ContaBancaria(Conta, Nome));
                Console.WriteLine("Conta criada com sucesso!");
                int i = contas.Count -1;
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Conta: {contas[i].Conta} \n" +
                    $"Nome: {contas[i].Nome}\n" +
                    $"Saldo: {contas[i].Saldo}");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Deseja realizar outra operação?");
                resposta = Console.ReadLine();
                if (resposta != "sim")
                {
                    Console.Read();
                }
                else
                {
                    Menu(contas);
                }
            }
            else
            {
                Console.WriteLine("Entre com o valor do Deposito");
                Saldo = double.Parse(Console.ReadLine());
                contas.Add(new ContaBancaria(Conta, Nome, Saldo));
                Console.Clear();
                Console.WriteLine("Conta criada com sucesso!");
                int i = contas.Count - 1;
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Conta: {contas[i].Conta} \n" +
                    $"Nome: {contas[i].Nome}\n" +
                    $"Saldo: {contas[i].Saldo}");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Deseja realizar outra operação?");
                resposta = Console.ReadLine();
                if (resposta != "sim")
                {
                    Console.Read();
                }
                else
                {
                    Menu(contas);
                }

            }
        }




    }
}
