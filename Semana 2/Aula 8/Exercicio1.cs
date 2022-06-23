using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8
{
    internal class Jogadora : Jogador
    {
        private List<Jogadora> jogadorList = new List<Jogadora>();

        public List<Jogadora> JogadorList
        {
            get { return jogadorList; }
            set { jogadorList = value; }
        }

        public Jogadora()
        {    
            JogadorList = Lista();
            Menu();
        
        }
        private Jogadora(string Nome, string Apelido, int Numero, int PontosHabilidade, string Cartoes, bool Suspenso, string Posicao ) :base(Nome, Apelido, Numero, PontosHabilidade, Cartoes, Suspenso, Posicao)
        {
            this.Nome = Nome;
            this.Apelido = Apelido;
            this.Numero = Numero;
            this.PontosHabilidade = PontosHabilidade;
            this.Cartoes = Cartoes;
            this.Suspenso = Suspenso;
            this.Posicao = Posicao;

        }

        private void Menu()
        {
            Console.WriteLine(JogadorList.Count);
            Console.WriteLine("\n------------- AREA DO TREINADOR -----------\n");
            Console.WriteLine("1 - Cadastrar Jogador\n" +
              "2 - Consultar Suspensão\n" +
              "3 - Lista de Alunos");

            Console.Write(">");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                  
                    break;

                case "2":
                    if (Apto()==false)
                    {
                        Console.WriteLine("O Jogador não está suspenso");
                    }
                    else
                    {
                        Console.WriteLine("O Jogador está suspenso");
                    };
                    
                    break;

                case "3":
                  
                    break;
                default:
                    Menu();
                    break;
            }

            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();

        }
        private int AcessaJogador(string nome)
        {
            int resposta = -1;
            for (int i = 0; i < JogadorList.Count; i++)
            {
                if (JogadorList[i].Nome == nome)
                {
                    resposta = i;
                    break;

                }
            }
            return resposta;
        }
        private bool Apto()
        {
            bool apto;
            Console.WriteLine("Entre com o nome do jogador que deseja consultar:");
            string nome=Console.ReadLine();
            int i = AcessaJogador(nome);
            apto = JogadorList[i].Suspenso;
            return apto;
        }

        private List<Jogadora> Lista()
        {
            List<Jogadora> jogador = new List<Jogadora>()
            {
                new Jogadora("Cristiano Ronaldo", "CR7", 7, 91, "Amarelo", false, "Atacante"),
                new Jogadora("Lionel Messi", "Messi", 10, 93, "-", false, "Atacante"),
            };
            return jogador;
        }
    }
}
