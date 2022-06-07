using System;

public class Mulheres{
    public string nome="nome";
    public string historia="historia";
    public string contribuicao="contribuição";
}

public class Song
{
    public string nome = "Blood wolf moon";
    public string autor = "Tommy Ashby";
    public string letra = "She is so shy \n " +
        "Scared of the sunrise \n" +
        "Only calm by noon \n" +
        "And he is a wallflower \n" +
        "Scared of the fallout \n " +
        "Of speaking too soon \n" +
        "She likes his eyes \n" +
        "The way they baptise \n" +
        "The morning light \n" +
        "And on the walk home \n" +
        "He steps real slow \n" +
        "Just to see she's alright \n" +
        "It only takes one move \n" +
        "Can you move me? \n" +
        "Under a blood wolf Moon \n" +
        "Down on Queen Street \n" +
        "He takes her hand \n" +
        "Light as moonshine \n" +
        "And pulls in close \n" +
        "When their mouths touch \n" +
        "She is helpless \n" +
        "She likes it though \n" +
        "It only takes one move \n" +
        "Can you move me? \n" +
        "Under a blood wolf Moon \n" +
        "Down on Queen Street \n" +
        "Think I can see the dawn \n" +
        "In a new light \n" +
        "Got you to focus on \n" +
        "I know your star sign \n" +
        "I'm coming home \n" +
        "To a real life \n" +
        "She is so shy \n" +
        "Scared of the sunrise \n" +
        "Only calm by noon \n" +
        "And he is a wallflower \n" +
        "Scared of the fallout \n" +
        "Of speaking to soon";
}
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
          /* 1 
            string nome;
            string endereco;
            int cep;
            int telefone;
            Console.WriteLine("Entre com o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Entre com o seu endereço:");
            endereco = Console.ReadLine();
            Console.WriteLine("Entre com o seu cep:");
            cep = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o seu telefone:");
            telefone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nome:" + nome);
            Console.WriteLine("Endereço:" + endereco);
            Console.WriteLine("CEP:" + cep);
            Console.WriteLine("Telefone:" + telefone); */

            /* 2 
            int num;
            Mulheres[] womanTech = new Mulheres[3];
            womanTech[0] = new Mulheres();
            womanTech[0].nome = "Ada Lovelace";
            womanTech[0].historia = "Sabemos que o Alan Turing é considerado o pai da computação, " +
                "mas quem de fato teve a ideia do primeiro programa computacional foi Ada Lovelace. " +
                "Em meados do século XIX, a famosa condessa de Lovelace, chamada de Augusta Ada King, " +
                "analisava e traduzia diversos materiais dos matemáticos contemporâneos.";
            womanTech[0].contribuicao = "Seus estudos contribuiram para que o primeiro " +
                "algoritmo no mundo fosse construido";
            womanTech[1] = new Mulheres();
            womanTech[1].nome = "Carol Shaw";
            womanTech[1].historia = "Se você gosta de videogames, vai adorar conhecer a história de Carol Shaw." +
                " Nascida na região do Vale do Silício, no ano de 1955, ela é considerada a primeira mulher que " +
                "começou a trabalhar com o desenvolvimento de jogos digitais.Shaw criou softwares para games e consoles, " +
                "sendo pioneira na geração procedural de conteúdo, que nada mais é que o aumento gradual da dificuldade " +
                "nos níveis do jogo.Em várias de suas obras, uma fase era totalmente diferente da outra, " +
                "conceito utilizado até hoje nos maiores títulos de jogos.";
            womanTech[1].contribuicao = "Com isso, a engenheira da computação foi uma das" +
                " primeiras colaboradoras da Atari";
            womanTech[2] = new Mulheres();
            womanTech[2].nome = "Frances Allen";
            womanTech[2].historia = "Frances Allen foi uma matemática que teve grande impacto na" +
                " Ciência da Computação. O setor em que se destacou foi o de otimização de " +
                "compiladores. Com as suas descobertas, foi possível criar sistemas de " +
                "aperfeiçoamento de códigos e de computação paralela";
            womanTech[2].contribuicao = "Isso fez com que diversos softwares passassem a trabalhar " +
                "de forma otimizada, inclusive nos processadores de baixo desempenho.";

            Console.WriteLine("Entre com um número o número correspondente para saber mais sobre essas mulheres \n" +
                "1 - Ada Love \n" +
                "2 - Carol Shaw \n" +
                "3 - Fances Allen");
            num = Convert.ToInt16(Console.ReadLine());
            if(num == 1)
            {
                Console.WriteLine(womanTech[0].nome);
                Console.WriteLine(womanTech[0].historia);
                Console.WriteLine(womanTech[0].contribuicao);
            } else if(num == 2)
            {
                Console.WriteLine(womanTech[1].nome);
                Console.WriteLine(womanTech[1].historia);
                Console.WriteLine(womanTech[1].contribuicao);
            }
            else
            {
                Console.WriteLine(womanTech[2].nome);
                Console.WriteLine(womanTech[2].historia);
                Console.WriteLine(womanTech[2].contribuicao);
            }*/
            /* 3 */
           

            Song song = new Song();
            Console.WriteLine(song.nome);
            Console.WriteLine(song.autor);
            Console.WriteLine(song.letra);

            /* 4 */

            Console.WriteLine("A área tech é pra você! Você é capaz! Não se" +
                " deixe levar por comentários ou 'opniões' contrarias. Se é o que você quer, vá em frente!" +
                "O mundo tech é pra você!");
        }
    }
}


// See https://aka.ms/new-console-template for more information
