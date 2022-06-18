using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    internal class SistemaLogin
    {
        
        static List<BD> listaLogin;

        

        public SistemaLogin(){

            listaLogin = new List<BD>(){
                    new BD("anaabalbi", "1234567"),
                    new BD("revier", "seraquevai"),
            };
            Menu();
            
        }

        private void Menu()
        {
            Console.WriteLine("------------- AREA DE LOGIN --------");
            Console.WriteLine("1 - Logar \n" +
              "2 - Criar \n" +
              "3 - Trocar a senha");
            Console.Write(">");
            string resposta = Console.ReadLine();

            switch (resposta)
            {
                case "1":
                    Logar();

                    break;
                case "2":
                    CriarConta();
                    break;
                case "3":
                    AlterarSenha();
                    break;
            }
        }


        private void Logar()
        {
            Console.WriteLine(listaLogin.Count);
            Console.WriteLine("Usuario:");
            Console.Write(">");
            string usuario= Console.ReadLine();
            Console.WriteLine("Senha:");
            Console.Write(">");
            string senha = Console.ReadLine();

            
            string resposta = (CheckLogin(usuario, senha) == 404) ? "Usuário não encontrado!" :
                (CheckLogin(usuario, senha) == 403) ? "Senha incorreta!" : "Bem vindo ao sistema!";
            
            Console.WriteLine(resposta);
                 
            
            Menu();
          
        }

        private int CheckLogin(string usuario, string senha)
        {
            int resposta = 404;
            for (int i = 0; i < listaLogin.Count; i++)
            {
                if (listaLogin[i].Senha == senha && listaLogin[i].Login == usuario)
                {

                    resposta = 200;
                    break;

                }
                else if (listaLogin[i].Senha != senha && listaLogin[i].Login == usuario)
                {
                    resposta = 403;
                    break;
                }

            }
            return resposta;
        }

        private void CriarConta()
        {
            Console.WriteLine("Usuario:");
            Console.Write(">");
            string usuario = Console.ReadLine();
            Console.WriteLine("Senha:");
            Console.Write(">");
            string senha = Console.ReadLine();
            listaLogin.Add(new BD(usuario, senha));
            Menu();
                        
            

        }
        private void AlterarSenha()
        {
            Console.WriteLine("Entre com a informação do login que deseja alterar senha:");
            Console.Write(">");
            string usuario = Console.ReadLine();
            Console.WriteLine("Entre com a senha antiga:");
            Console.Write(">");
            string senhaAntiga = Console.ReadLine();    
            int resposta=CheckLogin(usuario, senhaAntiga);
            if (resposta == 200)
            { 
                Console.WriteLine("Entre com a senha nova:");
                string senha = Console.ReadLine();
                if (Update(senha, usuario))
                {
                    Console.WriteLine("Senha alterada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi possível altera sua senha");
                }

            }
            else if(resposta == 403) 
            {
                Console.WriteLine("Senha incorreta, tente novamente");
                
            }else
            {
                Console.WriteLine("O usuário não foi encontrado, tente novamente");
            }
           
            Menu();
        }

        private bool Update(string senha,string usuario)
        {
            bool resposta = false;
            BD result = listaLogin.Find( delegate (BD list)
            {
                resposta = true;
                return list.Login == usuario;
            });
            result.Senha = senha;
            return resposta;
        }
        

    }
}
