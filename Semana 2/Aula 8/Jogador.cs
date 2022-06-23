using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8
{
    internal class Jogador
    {
        private string nome;
        private string apelido;
        private int numero;
        private int pontosHabilidade;
        private string cartoes;
        private bool suspenso;
        private string posicao;

        public string Nome { get { return nome; } set { nome = value; } }
        public string Apelido { get { return apelido; } set { apelido = value; } }
        public int Numero { get { return numero; } set { numero = value; } }
        public int PontosHabilidade
        {
            get { return pontosHabilidade; }
            set { pontosHabilidade = value; }
        }
        public string Cartoes { get { return cartoes; } set { cartoes = value; } }
        public bool Suspenso { get { return suspenso; } set { suspenso = value; } }
        public string Posicao { get { return posicao; } set { posicao = value; } }

        public Jogador()
        {

        }

        public Jogador(string nome, string apelido, int numero, int pontosHabilidade, string cartoes, bool suspenso, string posicao)
        {
            Nome = nome;
            Apelido = apelido;
            Numero = numero;
            PontosHabilidade = pontosHabilidade;
            Cartoes = cartoes;
            Suspenso = suspenso;
            Posicao = posicao;

        }
    }
}
