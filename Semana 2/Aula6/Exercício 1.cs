using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6
{
    internal class JogoDaVelha
    {
        private string[,] jogo = new string[3, 3];
        private int count = 0;
        private void Populate()
        {
            
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    count++;
                    jogo[l, c] = Convert.ToString(count);
                }
            }
        }

        public void Board()
        {
            Console.WriteLine("---------------------JOGO DA VELHA--------------------");
            Console.WriteLine();
            Console.WriteLine($"    {jogo[0, 0]}         |       {jogo[0, 1]}        |       {jogo[0, 2]}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"    {jogo[1, 0]}         |       {jogo[1, 1]}        |       {jogo[1, 2]}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"    {jogo[2, 0]}         |       {jogo[2, 1]}        |       {jogo[2, 2]}");
            Console.WriteLine();
        }

        public void Game()
        {
            Populate();
            Board();
            while(count > 0)
            {
                int i;
                string jogada;
                Console.WriteLine("Entre com a posição que você deseja jogar");
                i = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Entre com X ou O");
                jogada = Console.ReadLine();
                Jogada(i, jogada);
                Board();
                if ((jogo[0, 0] == "X" && jogo[0, 1] == "X" && jogo[0, 2] == "X") ||
                        (jogo[0, 0] == "X" && jogo[1, 0] == "X" && jogo[2, 0] == "X") ||
                        (jogo[0, 1] == "X" && jogo[1, 1] == "X" && jogo[2, 1] == "X") ||
                        (jogo[0, 0] == "X" && jogo[1, 1] == "X" && jogo[2, 2] == "X") ||
                        (jogo[2, 0] == "X" && jogo[1, 1] == "X" && jogo[0, 2] == "X") ||
                        (jogo[2, 0] == "X" && jogo[2, 1] == "X" && jogo[2, 2] == "X") ||
                        (jogo[1, 0] == "X" && jogo[1, 1] == "X" && jogo[1, 2] == "X") ||
                        (jogo[0, 2] == "X" && jogo[2, 1] == "X" && jogo[2, 2] == "X"))
                {
                    Console.WriteLine("O Jogador X ganhou!");
                    break;

                }
                else if ((jogo[0, 0] == "O" && jogo[0, 1] == "O" && jogo[0, 2] == "O") ||
                    (jogo[0, 0] == "O" && jogo[1, 0] == "O" && jogo[2, 0] == "O") ||
                    (jogo[0, 1] == "O" && jogo[1, 1] == "O" && jogo[2, 1] == "O") ||
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
        }
        private void Jogada(int i, string jogada)
        {
            string teste;
            teste = (i == 1) ? jogo[0, 0] = jogada : (i == 2) ? jogo[0, 1] = jogada : (i == 3) ? jogo[0, 2] = jogada :
                       (i == 4) ? jogo[1, 0] = jogada : (i == 5) ? jogo[1, 1] = jogada : (i == 6) ? jogo[1, 2] = jogada :
                       (i == 7) ? jogo[2, 0] = jogada : (i == 8) ? jogo[2, 1] = jogada : jogo[2, 2] = jogada;

        }
    }


}
        

