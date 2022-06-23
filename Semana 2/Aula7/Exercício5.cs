using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    
    internal class Televisao
    {
        private string marca;
        private int codigoSerie;
        private List<Canais> canais = new List<Canais>();

        public List<Canais> Canais { get { return canais; }
            set { canais = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int CodigoSerie { 
            get { return codigoSerie; }
            set { codigoSerie = value; } 
        }

        public Televisao()
        {
            Canais = CriarLista();
            Menu();
        }

        private void Menu()
        {

            Console.Clear();
            Console.WriteLine("\n--------- TELEVISÃO --------\n");
            Console.WriteLine("1 - Cadastrar \n" +
              "2 - Lista de cadastrados \n");

            Console.Write(">");
            string opcao = Console.ReadLine();

        }



        private static List<Canais> CriarLista()
        {
            List<Canais> lista = new List<Canais>();
            lista = new List<Canais>() { 
                new Canais("HBO Max", 833, 50, true),
                new Canais("Telecone", 621, 50, true)
            };
            return lista;
        }
    }
}
