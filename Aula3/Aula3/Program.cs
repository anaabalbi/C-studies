using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    public class Cedulas
    {
        public int cem = 0;
        public int cinq = 0;
        public int vinte = 0;
        public int dez = 0;
        public int cinco = 0;
        public int dois = 0;
    }

    public class Boletim
    {
        public string nome = "";
        public float nota1 = 0;
        public float nota2 = 0;
        public float nota3 =0;
        public float media = 0;
        public string conceito = "";

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario();
            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();
        }

        static void Cedulas()
        {
            Cedulas cedulas = new Cedulas();
            float valor = 0;
            Console.WriteLine("Entre com o valor para saber quantas cédulas você precisará");
            valor= float.Parse(Console.ReadLine());
            while(valor > 0)
            {
                if (valor >= 100)
                {
                    valor = valor - 100;
                    cedulas.cem++;
                } else if(valor >= 50)
                {
                    valor = valor - 50;
                    cedulas.cinq++;
                }else if (valor >= 20)
                {
                    valor = valor - 20;
                    cedulas.vinte++;
                }else if (valor >= 10)
                {
                    valor = valor - 10;
                    cedulas.cinq++;
                }else if (valor >= 5)
                {
                    valor = valor - 5;
                    cedulas.cinco++;
                }else if (valor >= 2)
                {
                    valor = valor - 2;
                    cedulas.dois++;
                }
                else{
                    break;
                }
            }
            Console.WriteLine($"Você precisará de: {cedulas.cem} nota(s) de R$ 100.00 {cedulas.cinq}" +
                $" nota(s) de R$ 50.00 {cedulas.vinte} nota(s) de R$ 20.00 {cedulas.dez} " +
                $"nota(s) de R$ 10.00 {cedulas.cinco} nota(s) de R$ 5.00 {cedulas.dois} nota(s) de R$ 2.00.");
        }

        static void Maior()
        {
            float[] numeros;
          
            numeros = new float[3];
            Console.WriteLine("Entre com os três valores");
            Console.WriteLine("Primeiro valor");
            numeros[0] = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor");
            numeros[1] = float.Parse(Console.ReadLine());
            Console.WriteLine("Terceiro valor");
            numeros[2] = float.Parse(Console.ReadLine());  
            float maior = numeros[0];
            for(int i=0; i<numeros.Length; i++)
            {
                if (maior < numeros[i])
                {
                    maior = numeros[i];
                }
            }
            Console.WriteLine($"A maior valor digitado é: {maior}");
        }
        
        static void Status()
        {
            var status = new Program();
            float media = status.Boletim();
           
            if(media < 6)
            {
                Console.WriteLine("Aluno REPROVADO");
            }
            else
            {
                Console.WriteLine("Aluno APROVADO");
            }


        }
        public float  Boletim()
        {
            Boletim boletim = new Boletim();
            Console.WriteLine("Entre com o nome do aluno:");
            boletim.nome = Console.ReadLine();
            Console.WriteLine("Entre com a primeira nota");
            boletim.nota1= float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a segunda nota");
            boletim.nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a terceira nota");
            boletim.nota3 = float.Parse(Console.ReadLine());
            boletim.media = (boletim.nota1 + boletim.nota2 + boletim.nota3) / 3;
            if(boletim.media < 6)
            {
                boletim.conceito = "F";
                Console.WriteLine($"{boletim.nome} obteve a média {boletim.media.ToString("N1")} e conceito {boletim.conceito}");
            } else if (boletim.media <= 7)
            {
                boletim.conceito = "D";
                Console.WriteLine($"{boletim.nome} obteve a média {boletim.media.ToString("N1")} e conceito {boletim.conceito}");
            } else if(boletim.media <= 8)
            {
                boletim.conceito = "C";
                Console.WriteLine($"{boletim.nome} obteve a média {boletim.media.ToString("N1")} e conceito {boletim.conceito}");
            } else if (boletim.media <= 9)
            {
                boletim.conceito = "B";
                Console.WriteLine($"{boletim.nome} obteve a média {boletim.media.ToString("N1")} e conceito {boletim.conceito}");
            }
            else
            {
                boletim.conceito = "A";
                Console.WriteLine($"{boletim.nome} obteve a média {boletim.media.ToString("N1")} e conceito {boletim.conceito}");
            }
            return boletim.media;
        }
        static void Salario()
        {
            float salario = 0;
            Console.WriteLine("Entre com o seu salário atual:");
            salario = float.Parse(Console.ReadLine());
            if (salario>0 & salario <= 400)
            {
                Console.WriteLine($"Novo salario: {(salario * 1.15).ToString("N2")} Reajuste ganho: {((salario * 1.15) - salario).ToString("N2")} Em percentual: 15%");
            } else if (salario>400 & salario <= 800)
            {
                Console.WriteLine($"Novo salario: {(salario * 1.12).ToString("N2")} Reajuste ganho: {((salario * 1.12) - salario).ToString("N2")} Em percentual: 12%");
            } else if (salario > 800 & salario <= 1200)
            {
                Console.WriteLine($"Novo salario: {(salario * 1.10).ToString("N2")} Reajuste ganho: {((salario * 1.10) - salario).ToString("N2")} Em percentual: 10%");
            } else if (salario > 1200 & salario <= 2000)
            {
                Console.WriteLine($"Novo salario: {(salario * 1.07).ToString("N2")} Reajuste ganho: {((salario * 1.07) - salario).ToString("N2")} Em percentual: 7%");
            }else
            {
                Console.WriteLine($"Novo salario: {(salario * 1.04).ToString("N2")} Reajuste ganho: {((salario * 1.04) - salario).ToString("N2")} Em percentual: 4%");
            }
        }

    }
}
