using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5
{
    internal class Voo
    {
        public int[] cadeiras = new int[100];
        public string date = "29/04/2017  22:45:00";
        public int codigoVoo;

        public void Executar()
        {
            Preencher();

            Console.WriteLine("Escolha uma das obções a seguir: \n" +
                 "1 - Selecionar uma assento \n" +
                 "2 - Assentos vagos no vôo");
            string resposta = Console.ReadLine();

            if (resposta == "1") {
                Reserva();
            } else if(resposta == "2"){

                Console.WriteLine($"Os assentos livres são:");
                Livre();
            }

        }
        public void Preencher()
        {

            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                cadeiras[i] = random.Next(0, 2);
            }

            codigoVoo = random.Next(2000000, 2900000);

        }

        public void Reserva()
        {
            Console.WriteLine("Entre com o número da cadeira que deseja reservar:");
            int cadeira = Convert.ToInt16(Console.ReadLine());
            bool taLivre = TaLivre(cadeira);
            int cadeiraAtualizada;
            bool atualizado;
            string reserva;
            if (taLivre)
            {
                Console.WriteLine("Deseja consular mais alguma coisa?");
                 reserva = Console.ReadLine();
                if (reserva == "não") {

                }
                else
                {
                    Executar();
                }

            }
            else
            {
                cadeiraAtualizada = ProxCadeira(cadeira);
                if (cadeiraAtualizada > 0)
                {
                    Console.WriteLine("Deseja reservar?");
                    reserva = Console.ReadLine();
                    if (reserva == "sim")
                    {
                        
                        atualizado = TaLivre(cadeiraAtualizada);
                        
                    }

                }
                else
                {
                    Console.WriteLine("Não há cadeira próxima vazia");

                }
            }


        }

        public bool TaLivre(int cadeira)
        {
            if (cadeiras[cadeira - 1] == 0)
            {
                Console.WriteLine("Reserva concluída com sucesso \n" +
                    "Informações da reserva: \n" +
                    $"Voo: {codigoVoo} | Assento: {cadeira} | {Data()}");
                return true;
            }
            else
            {

                return false;
            }
        }

        public void Livre()
        { 
            for (int i=0; i<100; i++)
            {   
                if(cadeiras[i] == 0)
                {
                    Console.Write($"{i+1} - ");
                }
                
            }

        }

        public int ProxCadeira(int cadeira)
        {
            int proxCadeira = 0;
            for (int i =cadeira+1; i<100; i++)
            {
                if (cadeiras[i] == 0)
                {
                    Console.WriteLine($"Esse assento está ocupado, mas o assento {i+1} está livre");
                    proxCadeira = i + 1;
                    return proxCadeira;
                    
                }

            }
            return proxCadeira; 
            

        }

        public string Data()
        {
            Voo date = new Voo();
            return $"O voo ocorrerá na data e horario: {date.date}";
        }

    }
}
