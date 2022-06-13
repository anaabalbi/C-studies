using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    internal class Program
    {
        public class Placar{
            public string pc = "Computador";
            public string voce = "Você";
            public int pcPonto = 0;
            public int vocePonto = 0;

        }
        static void Main(string[] args)
        {
            Jokenpo();
            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();
        }
        static void Numeros()
        {
            float[] numeros, multiplo;
            numeros = new float[10];
            multiplo = new float[10];


            Console.WriteLine("Entre com 10 números");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Entre com {i + 1}º número");
                numeros[i] = float.Parse(Console.ReadLine());
                multiplo[i] = numeros[i] * 5;
            }
            for (int i = 0; i < 10; i++) {
                if (i == 0)
                {
                    Console.Write($"Primeira lista de numeros: {numeros[i]}, ");
                }else if (i == 9)
                {
                    Console.WriteLine($"e {numeros[i]}. ");

                }else
                {
                    Console.Write($"{numeros[i]}, ");
                }              
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.Write($"Lista de numeros multiplicada por 5: {multiplo[i]}, ");
                }
                else if (i == 9)
                {
                    Console.WriteLine($"e {multiplo[i]}. ");

                }
                else
                {
                    Console.Write($"{multiplo[i]}, ");
                }
            }
        }
        static void ImparPar()
        {
            int[] par,impar;
            impar = new int[10];
            par = new int[10];
           
            int entrada;
            int indexPar = 0; 
            int indexImpar =0;

            Console.WriteLine("Entre com 10 números");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Entre o {i + 1}º número");
                entrada = Convert.ToInt16(Console.ReadLine());
                if (entrada % 2 == 0)
                {
                    par[indexPar]=entrada;
                    indexPar++;
                }
                else
                {
                    impar[indexImpar]=entrada;
                    indexImpar++;
                }
            }
            int count = 0;    
            while (count < indexPar)
            {
              
                
                    if (count == 0)
                    {
                        Console.Write($"Números pares: {par[count]}, ");
                    }
                    else if (count == indexPar-1)
                    {
                        Console.WriteLine($"e {par[count]}. ");
                    }
                    else
                    {
                    Console.Write($"{par[count]}, ");
                    }

                count++;
            }
            count = 0;
            while(count < indexImpar)
             {
                 if (count == 0)
                 {
                     Console.Write($"Números ímpares: {impar[count]}, ");
                 }
                 else if (count == indexImpar-1)
                 {
                     Console.WriteLine($"e {impar[count]}. ");

                 }
                 else
                 {
                     Console.Write($"{impar[count]}, ");
                 }
                count++;
             }
             

        }

        static void Jokenpo()
        {
            string continuar, rodada, jogada, resultado;
            Placar placar = new Placar();
            string[] computador = { "pedra", "papel", "tesoura" }; 
            Random random = new Random();
            do
            {
                Console.WriteLine("-------------- JOKENPÔ ----------------");
                Console.WriteLine();
                Console.WriteLine($"            {placar.voce}       |        {placar.pc}");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"              {placar.vocePonto}        |            {placar.pcPonto}");



                Console.WriteLine("Entre com o número de vezes que você quer jogar");
                int jogadas = Convert.ToInt16(Console.ReadLine());
                while (jogadas > 0)
                {
                    Console.WriteLine("Entre com a sua jogada - pedra, papel ou tesoura");
                    jogada=Console.ReadLine();
                    int jogadaComputador = random.Next(0, 3);
                    Console.WriteLine($"Você: {jogada}");
                    Console.WriteLine($"Computador: {computador[jogadaComputador]}");
                    rodada = (jogada == "tesoura" && computador[jogadaComputador] == "papel") ? "Você venceu" :
                    (jogada == "pedra" && computador[jogadaComputador] == "tesoura") ? "Você venceu" :
                    (jogada == "papel" && computador[jogadaComputador] == "pedra") ? "Você venceu" :
                    (jogada == "papel" && computador[jogadaComputador] == "tesoura") ? "Computador venceu" :
                    (jogada == "tesoura" && computador[jogadaComputador] == "pedra") ? "Computador venceu" :
                    (jogada == "pedra" && computador[jogadaComputador] == "papel") ? "Computador venceu" : "Ninguém venceu";

                    Console.WriteLine(rodada);

                    int teste = (rodada == "Você venceu") ? placar.vocePonto = placar.vocePonto + 1 : (rodada=="Computador venceu") ? placar.pcPonto = placar.pcPonto + 1 : 0;
                    Console.WriteLine();
                    Console.WriteLine($"            {placar.voce}       |        {placar.pc}");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"            {placar.vocePonto}       |        {placar.pcPonto}");
                    jogadas--;


                }

                resultado = (placar.vocePonto == placar.pcPonto) ? "Empatou!" : (placar.vocePonto > placar.pcPonto) ? "Parabéns, você ganhou!" : "OPS,não foi dessa vez. O computador ganhou";
                Console.WriteLine(resultado);

                Console.WriteLine("Deseja jogar novamente?");
                continuar = Console.ReadLine();
            } while (continuar == "sim");
           
        }

        static void JogoDaVelha()
        {
            string resposta;
            do
            {
                string[,] jogo = new string[3, 3];
                
                int count = 0;
                for (int l = 0; l < 3; l++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        count++;
                        jogo[l, c] = Convert.ToString(count);
                    }
                }
                Console.WriteLine("---------------------JOGO DA VELHA--------------------");
                Console.WriteLine();
                Console.WriteLine($"    {jogo[0, 0]}         |       {jogo[0, 1]}        |       {jogo[0, 2]}");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"    {jogo[1, 0]}         |       {jogo[1, 1]}        |       {jogo[1, 2]}");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"    {jogo[2, 0]}         |       {jogo[2, 1]}        |       {jogo[2, 2]}");
                Console.WriteLine();
                int i;
                string jogada, teste;
                while (count > 0)
                {
                    Console.WriteLine("Entre com a posição que você deseja jogar");
                    i = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Entre com X ou O");
                    jogada=Console.ReadLine();

                    teste=(i == 1) ? jogo[0,0] = jogada : (i == 2) ? jogo[0,1] = jogada : (i == 3) ? jogo[0,2] = jogada :
                        (i == 4) ? jogo[1,0] = jogada : (i == 5) ? jogo[1,1] = jogada : (i == 6) ? jogo[1,2] = jogada :
                        (i == 7) ? jogo[2,0] = jogada :(i == 8) ? jogo[2,1] = jogada : jogo[2,2] = jogada;
                  
                    Console.WriteLine();
                    Console.WriteLine($"    {jogo[0, 0]}         |       {jogo[0, 1]}        |       {jogo[0, 2]}");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine($"    {jogo[1, 0]}         |       {jogo[1, 1]}        |       {jogo[1, 2]}");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine($"    {jogo[2, 0]}         |       {jogo[2, 1]}        |       {jogo[2, 2]}");

                    if ((jogo[0, 0] == "X" && jogo[0, 1] == "X" && jogo[0, 2] == "X") ||
                        (jogo[0, 0] == "X" && jogo[1, 0] == "X" && jogo[2, 0] == "X") ||
                        (jogo[0, 1] == "X" && jogo[1, 1] == "X" && jogo[2, 1] == "X") ||
                        (jogo[0, 0] == "X" && jogo[1, 1] == "X" && jogo[2, 2] == "X") ||
                        (jogo[0, 2] == "X" && jogo[1, 1] == "X" && jogo[0, 2] == "X") ||
                        (jogo[2, 0] == "X" && jogo[2, 1] == "X" && jogo[2, 2] == "X") ||
                        (jogo[1, 0] == "X" && jogo[1, 1] == "X" && jogo[1, 2] == "X") ||
                        (jogo[0, 2] == "X" && jogo[2, 1] == "X" && jogo[2, 2] == "X"))
                    {
                        Console.WriteLine("O Jogador X ganhou!");
                        break;

                    }
                    else if ((jogo[0, 0] == "O" && jogo[0, 1] == "O" && jogo[0, 2] == "O") ||
                        (jogo[0, 0] == "O" && jogo[1, 0] == "O" && jogo[2, 0] == "O") ||
                        (jogo[0, 1] == "X" && jogo[1, 1] == "O" && jogo[2, 1] == "O") ||
                        (jogo[0, 0] == "O" && jogo[1, 1] == "O" && jogo[2, 2] == "O") ||
                        (jogo[0, 2] == "O" && jogo[1, 1] == "O" && jogo[0, 2] == "O") ||
                        (jogo[2, 0] == "O" && jogo[2, 1] == "O" && jogo[2, 2] == "O") ||
                        (jogo[1, 0] == "O" && jogo[1, 1] == "O" && jogo[1, 2] == "O") ||
                        (jogo[0, 2] == "O" && jogo[2, 1] == "O" && jogo[2, 2] == "O"))
                    {
                        Console.WriteLine("O Jogador O ganhou!");
                        break;
                    }
                    else if (count == 1)
                    {
                        Console.WriteLine("Deu Velha!");
                    }
                    count++;
                }

                Console.WriteLine("Quer jogar novamente");
                resposta = Console.ReadLine();

            } while (resposta == "sim");

         }   
    }
}
