using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6
{
    internal class ManipulaString
    {
        private string entrada;
        private string iniciais="";

       public ManipulaString(string entrada)
        {
            this.entrada = entrada;

        }

        public void Iniciais()
        {
            int count=0;
            int index=0;
            string[] nomes = new string[10];
        
            
            while(count < entrada.Length)
            {

                if (Convert.ToChar(entrada[count]) != 32)
                {
                    nomes[index]= nomes[index] + entrada[count];

                }
                else
                {
                    index++;
                }
                count++;
            }
            for(int i=0; i < nomes.Length; i++)
            {
                if (nomes[i] != null)
                {
                    if (nomes[i].Length > 2)
                    {
                        string name = nomes[i];
                        iniciais = iniciais + name[0] + ". ";
                    }
                    else
                    {
                        string name = nomes[i];
                        iniciais = iniciais + name +" ";
                    }
                }
                
            }
                     
            Console.WriteLine(iniciais);
           
        }

        public void Inverte()
        {
            string invertido = "";
            for (int i = entrada.Length - 1; i >= 0; i--)
            {
                invertido= invertido + entrada[i];
            }
            Console.WriteLine(invertido);
        }
    }
}
