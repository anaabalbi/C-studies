using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula7
{
   
    public class PetShop : Tutor {

        private string nomePet, especie, cor, observacao;
        private int idade;
        private List<PetShop> lista = new List<PetShop> ();

        public List<PetShop> Lista { get { return lista; } set { lista = value; } }

        public string NomePet
        {
            get { return nomePet; }
            set { nomePet = value; }
        }
        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
       
        public PetShop()
        {
            Lista = CriarLista();
            Menu();

            
        }
        public PetShop(string nomePet, string especie, string cor, string observacao,int idade, string nome, string endereco)
        {
            this.NomePet = nomePet;
            this.Especie= especie;
            this.Cor = cor;
            this.Observacao = observacao;
            this.Idade = idade;
            this.Nome = nome;
            this.Endereco = endereco;
            

        }

        public void Menu()
        {
            
            Console.Clear();
            Console.WriteLine("\n------------- PETSHOP --------\n");
            Console.WriteLine("1 - Cadastrar \n" +
              "2 - Lista de cadastrados \n");

            Console.Write(">");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarPet();
                    break;
                case "2":
                    Imprimir();
                    break;
                default:
                    Menu();
                    Console.WriteLine("Pressione ENTER para sair...");
                    Console.Read();
                    break;
            }
        }

        private void CadastrarPet()
        {
            Console.WriteLine("Entre com o nome do pet");
            string NomePet = Console.ReadLine();
            Console.WriteLine("Qual é a espécie?");
            string Especie = Console.ReadLine();
            Console.WriteLine("Qual é sua cor?");
            string Cor = Console.ReadLine();
            Console.WriteLine("Alguma observação sobre o PET?");
            string Observacao = Console.ReadLine();
            Console.WriteLine("Entre com a idade do PET");
            int Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre aas informações do tutor");
            Console.WriteLine("Nome:");
            string Nome = Console.ReadLine();
            Console.WriteLine("Endereço:");
            string Endereco = Console.ReadLine();

            lista.Add(new PetShop(NomePet, Especie, Cor, Observacao, Idade, Nome, Endereco));
            
            

            Console.WriteLine("CADASTRO EFETUADO COM SUCESSO!");
            Menu();

            

        }

        private void Imprimir()
        {
            Console.Clear();
            Console.WriteLine("\n------------ LISTA DE PETS ------------\n");
            Lista.ForEach(i => Console.WriteLine(" Pet: {0}\n Especie: {1}\n Cor: {2}\n Observação: {3}\n Idade: {4}\n Tutor: {5}\n Endereço: {6}\n -------------------------------------------",  i.NomePet, i.Especie, i.Cor, i.Idade, i.Observacao,i.Nome,i.Endereco));
            Console.WriteLine("\nDeseja voltar pro menu?");
            string resposta = Console.ReadLine();
            if (resposta == "sim")
            {
                Console.Clear();
                Menu();
            }
        }

        public static List<PetShop> CriarLista()
        {
            List<PetShop> lista = new List<PetShop>() {  new PetShop("Mel", "Cachorro", "Caramelo", "Tem dermatite", 2, "Livia Cardoso", "Rua Brasil - Curitiba")
            };

            Console.WriteLine(lista.Count);
            return lista;
        }


    }
   
}
