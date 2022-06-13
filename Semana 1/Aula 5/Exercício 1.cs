using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5
{
    internal class Aluno
    {
        public int matricula;
        public string nome;
        public float prova1;
        public float prova2;
        public float trab;
        

        public float Media()
        {   
            float media = (prova1+ prova2 + trab) / 3;
            return media;
        }

        public float ProvaFinal()
        {
            float media=Media();
            
            if (media < 7)
            {
                return   14 - media;
            }
            else
            {
                return -1;
            }
            
        }
    }
}
