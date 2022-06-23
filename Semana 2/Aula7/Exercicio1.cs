using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    internal class Aluno
    {

        private List<Aluno> alunos = new List<Aluno>();
        private int matricula;
        private string nome;
        private double prova1;
        private double prova2;
        private double trab;

        public List<Aluno> Alunos
        {
            get { return alunos; }
            set { alunos = value; }
        }

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }

        }

        public double Trab
        {
            get { return trab; }
            set { trab = value; }

        }

        public double Prova1
        {
            get { return prova1; }
            set { prova1 = value; }
        }

        public double Prova2
        {
            get { return prova2; }
            set { prova2 = value; }
        }

        public Aluno(int matricula, string nome, double prova1, double prova2, double trab)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.Prova1 = prova1;
            this.Prova2 = prova2;
            this.Trab = trab;
        }
        
        public Aluno() {

            Alunos = CriarLista();
            Menu();

        }

        private static List<Aluno> CriarLista()
        {
            List<Aluno> alunos = new List<Aluno>();
            alunos = new List<Aluno>(){
                    new Aluno(1234567, "Ana Amelia", 9.6, 7.8, 6.5 ),
                    new Aluno(1324567, "João Claúdio", 5.6, 7.0, 10.0 ),
            };
            return alunos;
        }
        public void Menu()
        {
            Console.WriteLine("\n------------- AREA DO PROFESSOR --------\n");
            Console.WriteLine("1 - Cadastrar Aluno \n" +
              "2 - Consultar \n" +
              "3 - Lista de Alunos");

            Console.Write(">");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Cadastrar();
                    break;

                case "2":
                    Console.Clear();
                    Consultar();
                    break;

                case "3":
                    ListarAlunos();
                    break;
                default:
                    Menu();
                    break;
            }

            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();


        }

        private void Cadastrar()
        {
            Console.WriteLine("Caso o aluno ainda não tenha nota entre com -1, e depois atualize o cadastro.");
            Console.WriteLine("Entre com a matricula do aluno:");
            int matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o nome do aluno:");
            string nome = Console.ReadLine();
            Console.WriteLine("Entre a nota da primeia prova:");
            double prova1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre a nota da segunta prova:");
            double prova2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre a nota do trabalho:");
            double trab = double.Parse(Console.ReadLine());

            Alunos.Add(new Aluno(matricula, nome, prova1, prova2, trab));
            Console.Clear();
            Console.WriteLine("\nMensagem: Aluno cadastrado com sucesso!\n");
            Menu();

        }

        private void Consultar(){
            Console.WriteLine("\n------------- AREA DO PROFESSOR --------\n");
            Console.WriteLine("1 - Média \n" +
              "2 - Atualizar notas \n" +
              "3 - Informações");
            Console.Write(">");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Media();
                    break;
                case "2":
                    AtualizaNotas();
                    break;
                case "3":
                    ImprimeAluno();
                    break;
                default:
                    Menu();
                    break;
            }
        }
        private void ImprimeAluno()
        {
            Console.WriteLine("Entre com a matrícula do aluno:");
            int matricula = int.Parse(Console.ReadLine());
            int i = AcessaAluno(matricula);
            if (i < 0)
            {
                Console.Clear();
                Console.WriteLine("\nMensagem: Aluno não encontrado - tente novamente \n");
                Consultar();
                
            }
            else
            {
                Console.WriteLine($"\nMatricula: {Alunos[i].Matricula}\n" +
                $"Nome: {Alunos[i].Nome}\n" +
                $"Prova 1: {Alunos[i].Prova1}\n" +
                $"Prova 2: {Alunos[i].Prova2}\n" +
                $"Trabalho: {Alunos[i].Trab}");
                Console.WriteLine("\nDeseja voltar pro menu?");
                string resposta = Console.ReadLine();
                if (resposta =="sim")
                {
                    Console.Clear();
                    Menu();
                }
            }

        }
        private int AcessaAluno(int matricula)
        {
            int resposta = -1;
            for (int i = 0; i < Alunos.Count; i++)
            {
                if (Alunos[i].Matricula == matricula)
                {
                    resposta = i;
                    break;

                }
            }
            return resposta;
        }

        private void ListarAlunos()
        {
            Console.Clear();
            Console.WriteLine("\n------------ LISTA DE ALUNOS ------------\n");
            Alunos.ForEach(i => Console.WriteLine("{0}\t{1}\t", i.Matricula, i.Nome));
            Console.WriteLine("\nDeseja voltar pro menu?");
            string resposta = Console.ReadLine();
            if (resposta == "sim")
            {
                Console.Clear();
                Menu();
            }
        }

        private void Media()
        {
            Console.Clear();
            Console.WriteLine("\nEntre com a matrícula do aluno que deseja saber a média");
            int matricula = int.Parse(Console.ReadLine());
            int i = AcessaAluno(matricula);
            if (i < 0)
            {
                Console.Clear();
                Console.WriteLine("\nMensagem: Aluno não encontrado - tente novamente \n");
                Consultar();
            }
            else
            {
                if (Alunos[i].Prova1 == -1 || Alunos[i].Prova2 == -1 || Alunos[i].Trab == -1)
                {
                    Console.Clear();
                    Console.WriteLine("\nMensagem: Não foi possível calcular a média, alguma nota não foi cadastrada");
                    Menu();
                }
                else {
                    double media = (Alunos[i].Prova1 + Alunos[i].Prova2 + Alunos[i].Trab) / 3;
                    Console.WriteLine($"A média do(a) aluno(a) {Alunos[i].Nome}, matricula - {matricula} foi: {media.ToString("N2")}");
                    ProvaFinal(media, Alunos[i].Nome);
                    Console.WriteLine("Deseja voltar pro menu?");
                    string resposta = Console.ReadLine();
                    if (resposta == "sim")
                    {
                        Console.Clear();
                        Menu();
                    }
                }
               
            }
            
        }

        private void AtualizaNotas()
        {
            Console.WriteLine("Entre com a matrícula do aluno:");
            int matricula = int.Parse(Console.ReadLine());
            int i = AcessaAluno(matricula);
            if (i < 0)
            {
                Console.WriteLine("Aluno não encontrado - tente novamente");
            }
            else
            {
                double nota;
                Console.WriteLine("Qual nota deseja atualizar/cadastrar?\n" +
                    "1 - Prova 1\n" +
                    "2 - Prova 2\n" +
                    "3 - Trabalho");
                string qualNota = Console.ReadLine();
                switch (qualNota)
                {
                    case "1":
                        Console.WriteLine("Digite a nota");
                        nota = double.Parse(Console.ReadLine());
                        Alunos[i].Prova1 = nota;
                        Console.Clear();
                        Console.WriteLine("\nMensagem: Nota cadastrada com sucesso!\n");
                        Menu();
                        break;
                    case "2":
                        
                        Console.WriteLine("Digite a nota");
                        nota = double.Parse(Console.ReadLine());
                        Alunos[i].Prova2= nota;
                        Console.Clear();
                        Console.WriteLine("\nMensagem: Nota cadastrada com sucesso!\n");
                        Menu();
                        break;
                    case "3":
                        Console.WriteLine("Digite a nota");
                        nota = double.Parse(Console.ReadLine());
                        Alunos[i].Trab = nota;
                        Console.Clear();
                        Console.WriteLine("\nMensagem: Nota cadastrada com sucesso!\n");
                        Menu();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nOpcão inválida\n");
                        AtualizaNotas();
                        break;
                }
            }
         

        }

        public void ProvaFinal(double media, string aluno)
        {
            if (media < 7)
            {
                Console.WriteLine($"{aluno} precisará fazer a prova final. Necessitando tirar ao menos" +
                    $" {(14 - media).ToString("N2")} para ser aprovado");
            }

        }
    }
}


