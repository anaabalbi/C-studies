using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6
{
    internal class Sorteio
    {
        private int numero;
        private void Sortear()
        {
            Random valor = new Random();
            this.numero = valor.Next(1, 1000);

            
        }

        public void Jogar()
        {
            string resposta;
            do
            {
                Sortear();
                Console.WriteLine("Número sorteado!");
                Console.WriteLine("Entre com um chute");
                int chute = int.Parse(Console.ReadLine());
                int count = 1;
                if (chute != this.numero)
                {   
                    while (chute != this.numero){
                        if (chute>this.numero)
                        {
                            Console.WriteLine("Seu palpite é MAIOR que o número sorteado");
                            Console.WriteLine("Entre com outro chute:");
                            chute = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Seu palpite é MENOR que o número sorteado");
                            Console.WriteLine("Entre com outro chute:");
                            chute = int.Parse(Console.ReadLine());

                        }
                        count++;

                     }
                    Console.WriteLine($"Você acertou em {count} chance. O número sorteado foi {this.numero}");

                }
                else
                {
                    Console.WriteLine($"Você acertou em {count} chance. O número sorteado foi {this.numero}");
                }

                Console.WriteLine("Deseja jogar novamente?");
                resposta = Console.ReadLine();
            }while (resposta=="sim");

        }

        
    }
}
