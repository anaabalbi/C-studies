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
        private List<ContaBancaria> contaBancarias = new List<ContaBancaria>();

        public List<ContaBancaria> ContaBancarias
        {
            get { return contaBancarias; }
            set { contaBancarias = value; }
        }
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

        public ContaBancaria()
        {
            ContaBancarias = CriarLista();
            Menu();
            
        }

        public ContaBancaria(int conta, string nome, double saldo=0)
        {
            this.Conta = conta;
            this.Nome = nome;
            this.Saldo = saldo;
          
        }

        private static List<ContaBancaria> CriarLista()
        {
            List<ContaBancaria> contaBancarias = new List<ContaBancaria>();
            contaBancarias = new List<ContaBancaria>()
            {
                new ContaBancaria(1234567, "Ana Amelia", 1000),
                new ContaBancaria(9876543, "Jose Claudio", -50),

            };
            return contaBancarias;
        }

        public void Menu()
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
                    Depositar();
                    break;

                case "2":
                    Console.Clear();
                    Sacar();
                    break;

                case "3":
                    Alterar();
                    break;
                case "4":
                    NovaConta();
                    break;
                default:
                    Menu();
                    Console.WriteLine("Pressione ENTER para sair...");
                    Console.Read();
                    break;
            }

          
        }

        private int AcessarConta(int contaCorrente)
        {
            int resposta = -1;
            for (int i = 0; i < ContaBancarias.Count; i++)
            {
                if (ContaBancarias[i].Conta == contaCorrente)
                {
                    resposta = i;
                    break;

                }
            }
            return resposta;
        }
        private void Depositar()
        {
            Console.Clear();
            Console.WriteLine("\nEntre com o número da conta que deseja Depositar");
            int contaCorrente = int.Parse(Console.ReadLine());
            int i=AcessarConta(contaCorrente);
            if (i < 0)
            {
                Console.Clear();
                Console.WriteLine("\nConta não encontrada, tente novamente\n");
                Menu();

            }
            else
            {
              
                Console.WriteLine("\nEntre com o valor do deposito");
                double deposito = double.Parse(Console.ReadLine());
                ContaBancarias[i].Saldo = ContaBancarias[i].Saldo + deposito;
                Console.WriteLine("Deposito realizado com sucesso!");
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Conta: {ContaBancarias[i].Conta} \n" +
                    $"Nome: {ContaBancarias[i].Nome}\n" +
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
                    Menu();
                }
            }


        }

        private void Sacar()
        {
            Console.Clear();
            Console.WriteLine("\nEntre com o número da conta que deseja Sacar");
            int contaCorrente = int.Parse(Console.ReadLine());
            int i = AcessarConta(contaCorrente);
            if (i < 0)
            {
                Console.Clear();
                Console.WriteLine("\nConta não encontrada, tente novamente\n");
                Menu();

            }
            else
            {
               
                Console.WriteLine("Entre com o valor do saque");
                double saque = double.Parse(Console.ReadLine());
                ConsultaSaque(saque, i);       
                Console.WriteLine("Deseja realizar outra operação?");
                string resposta = Console.ReadLine();
                if (resposta != "sim")
                {
                    Console.Read();
                }
                else
                {
                    Menu();
                }
            }

        }

        private void ConsultaSaque(double saque, int i)
        {
            if (saque <= ContaBancarias[i].Saldo)
            {
                Console.Clear();
                ContaBancarias[i].Saldo = ContaBancarias[i].Saldo - saque;
                Console.WriteLine("Saque realizado com sucesso!");
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Conta: {ContaBancarias[i].Conta} \n" +
                    $"Nome: {ContaBancarias[i].Nome}\n" +
                    $"Valor: R${saque}\n" +
                    $"Saldo atual: R${ContaBancarias[i].Saldo}");
                Console.WriteLine("---------------------------------");
            }
            else
            {
                Console.WriteLine("O saque não realizado. Valor do saque maior que o disponível");
            }
        }

        private void Alterar()
        {
            Console.Clear();
            Console.WriteLine("\nEntre com o número da conta que deseja alterar o nome");
            int contaCorrente = int.Parse(Console.ReadLine());
            int i = AcessarConta(contaCorrente);
            if (i < 0)
            {
                Console.Clear();
                Console.WriteLine("\nConta não encontrada, tente novamente\n");
                Menu();

            }
            else
            {
                
                Console.WriteLine("\nEntre com o novo nome");
                string novoNome = Console.ReadLine();
                ContaBancarias[i].Nome = novoNome;
                Console.WriteLine("Nome trocado com sucesso!");
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Conta: {ContaBancarias[i].Conta} \n" +
                    $"Nome: {ContaBancarias[i].Nome}");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Deseja realizar outra operação?");
                string resposta = Console.ReadLine();
                if (resposta != "sim")
                {
                    Console.Read();
                }
                else
                {
                    Menu();
                }

            }
        }
      
        private void NovaConta()
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
                ContaBancarias.Add(new ContaBancaria(Conta, Nome));
                Console.WriteLine("Conta criada com sucesso!");
                int i = ContaBancarias.Count -1;
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Conta: {ContaBancarias[i].Conta} \n" +
                    $"Nome: {ContaBancarias[i].Nome}\n" +
                    $"Saldo: {ContaBancarias[i].Saldo}");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Deseja realizar outra operação?");
                resposta = Console.ReadLine();
                if (resposta != "sim")
                {
                    Console.Read();
                }
                else
                {
                    Menu();
                }
            }
            else
            {
                Console.WriteLine("Entre com o valor do Deposito");
                Saldo = double.Parse(Console.ReadLine());
                ContaBancarias.Add(new ContaBancaria(Conta, Nome, Saldo));
                Console.Clear();
                Console.WriteLine("Conta criada com sucesso!");
                int i = ContaBancarias.Count - 1;
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Conta: {ContaBancarias[i].Conta} \n" +
                    $"Nome: {ContaBancarias[i].Nome}\n" +
                    $"Saldo: {ContaBancarias[i].Saldo}");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Deseja realizar outra operação?");
                resposta = Console.ReadLine();
                if (resposta != "sim")
                {
                    Console.Read();
                }
                else
                {
                    Menu();
                }

            }
        }




    }
}
