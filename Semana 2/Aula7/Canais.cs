using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    internal class Canais
    {
        private string nome;
        private int numero;
        private int volume;
        private bool status;

        public string Nome { get { return nome; } set { nome = value; } }
        public int Numero { get { return numero; } set { numero = value; } }
        public int Volume { get { return volume; } set { volume = value; } }
        public bool Status { get { return status; } set { status = value; } }

        public Canais(string nome, int numero, int volume, bool status)
        {
            Nome = nome;
            Numero = numero;
            Volume = volume;
            Status = status;
        }


    }
}
