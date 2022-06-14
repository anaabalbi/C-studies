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
        
        public void Executar()
        {
            string provaFinal;
           
            Console.WriteLine("Entre com a matricula do aluno");
            matricula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre o nome do aluno");
            nome = Console.ReadLine();
            Console.WriteLine("Entre a nota da primeia prova ");
            prova1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre a nota da segunta prova");
            prova2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre a nota do trabalho");
            trab = float.Parse(Console.ReadLine());

            Console.WriteLine($"A média do {nome} da matricula - {matricula} foi: {Media().ToString("N2")}");
            provaFinal = (ProvaFinal() == -1) ? $"{nome} não precisa de prova final" : $"{nome} precisa de {ProvaFinal().ToString("N2")} na prova final para passar de ano";
            Console.WriteLine(provaFinal);
        }

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
