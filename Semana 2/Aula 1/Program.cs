using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você deseja executar \n" +
              "1 - Jogo da Velha \n" +
              "2 - Salario \n" +
              "3 - Fatura \n" +
              "4 - Sorteio \n" +
              "5 - Manipulação string");
            string resposta = Console.ReadLine();

            switch (resposta)
            {
                case "1":
                    Exercicio1();
                    break;

                case "2":
                    Exercicio2();
                    break;

                case "3":
                    Exercicio3();
                    break;

                case "4":
                    Exercicio4();
                    break;

                case "5":
                    Exercicio5();
                    break;

            }
          

            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();
        }
        static void Exercicio1()
        {
            JogoDaVelha velha = new JogoDaVelha();
            velha.Game();
        }
        static void Exercicio2()
        {
            Console.WriteLine("Entre com o nome do empregado:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Entre com o cargo que {nome} ocupa na empresa:");
            string cargo = Console.ReadLine();
            Console.WriteLine("Entre com o salário:");
            double salario = double.Parse(Console.ReadLine());
            Empregado empregado = new Empregado(nome, cargo, salario);
            empregado.Aumento();
            empregado.MostraSalario();
            
        }
        static void Exercicio3()
        {
            Console.WriteLine("Entre com o código do produto:");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Entre com a descrição do produto:");
            string descricao = Console.ReadLine();
            Console.WriteLine("Ente com o preço do produto:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a quantidade que deseja comprar:");
            int quantidade = Convert.ToInt16(Console.ReadLine());
            Fatura fatura = new Fatura(codigo, descricao, quantidade, preco);
            fatura.ValorFatura();
        }
        static void Exercicio4() {
            Sorteio sorteio = new Sorteio();
            sorteio.Jogar();
        }
        static void Exercicio5()
        {
            string cadeiaCaracteres, entrada;
            Console.WriteLine("O que você deseja manipular: \n" +
                "1 - Nome Completo - retorna as iniciais do seu nome \n" +
                "2 - Inverte \n" +
                "3 - Conta - retorna o número de consoantes e vogais");
            entrada  = Console.ReadLine();
            switch (entrada)
            {
                case "1":
                    Console.WriteLine($"Entre com o seu nome completo.");
                    cadeiaCaracteres = Console.ReadLine();
                    ManipulaString fullname = new ManipulaString(cadeiaCaracteres);
                    fullname.Iniciais();
                    break;

                case "2":
                    Console.WriteLine($"Entre com o texto a ser invertido.");
                    cadeiaCaracteres = Console.ReadLine();
                    ManipulaString inverte = new ManipulaString(cadeiaCaracteres);
                    inverte.Inverte();
                    break;
                case "3":
                    Console.WriteLine($"Entre com o texto para ser contato.");
                    cadeiaCaracteres = Console.ReadLine();
                    ManipulaString conta = new ManipulaString(cadeiaCaracteres);
                    conta.Conta();
                    break;

            }
        }
    }
}
