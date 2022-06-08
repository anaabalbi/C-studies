using System;



namespace Program
{   public class Date
    {
        public int day = 0;
        public int month = 0;
        public int year = 0;
    }
    
    public class Hour
    {
        public int hour = 0;
        public int min = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {

            SomaInteiros();

        }
        static void SomaInteiros()
        {
            int[] numeros;
            numeros = new int[10];
            int soma = 0;
            Console.WriteLine("Ditige 10 números inteiros");
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Entre com o {i + 1}º número");
                numeros[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                soma = soma + numeros[i];
            }
            Console.WriteLine($"O somatório dos números  {numeros[0]}, {numeros[1]}, {numeros[2]}" +
                $" {numeros[3]}, {numeros[4]},{numeros[5]}, {numeros[6]}, {numeros[7]},{numeros[8]} e {numeros[9]} é {soma}");
        }
            
        static void Aniversario()
        {
            /* 1 */
            var date = DateTime.Now;
            int month = date.Month;
            int year = date.Year;
            Date birthDay = new Date();

            Console.WriteLine("Entre primeiramente com o dia do seu nascimento:");
            birthDay.day = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("O mês:");
            birthDay.month = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("O ano:");
            birthDay.year = Convert.ToInt16(Console.ReadLine());

            if (birthDay.month < month)
            {
                Console.WriteLine($"Sua data de nascimento é: {birthDay.day}/{birthDay.month}/{birthDay.year}. E você tem {(year - birthDay.year)} anos");
            }
            else
            {
                Console.WriteLine($"Sua data de nascimento é: {birthDay.day}/{birthDay.month}/{birthDay.year}. E você tem {((year - 1) - birthDay.year)} anos");
            }

            /* ---------------------------- */

            string birthday;
            string mes="";
            string ano = "";
            Console.WriteLine("Entre com a sua data de nascimento nesse formato DD/MM/YY");
            birthday = Console.ReadLine();
            for (int i = 3; i < 5; i++)
            {
                mes = mes + birthday[i];
            }
            birthDay.month = Convert.ToInt16(mes);
            for (int i = 6; i <10; i++)
            {
                ano = ano + birthday[i];
            }
            birthDay.year = Convert.ToInt16(ano);
            if (birthDay.month < month)
            {
                Console.WriteLine($"Sua data de nascimento é: {birthDay.day}/{birthDay.month}/{birthDay.year}. E você tem {(year - birthDay.year)} anos");
            }
            else
            {
                Console.WriteLine($"Sua data de nascimento é: {birthDay.day}/{birthDay.month}/{birthDay.year}. E você tem {((year - 1) - birthDay.year)} anos");
            }





        }



        static void Salario()
        {
            string hourWork;
            string horas="";
            string minutos = "";
            float pagamento = 0;
            float valor=0;
            int index;
            Hour hour = new Hour();
            Console.WriteLine("Entre com o número de horas trabalhadas no formato HH:MM");
            hourWork=Console.ReadLine();
            index = hourWork.IndexOf(':');
            for(int i=0; i<index; i++)
            {
                horas = horas + hourWork[i];
            }
            hour.hour = Convert.ToInt16(horas);
            for (int i = index+1; i < hourWork.Length; i++)
            {
                minutos = minutos + hourWork[i];
            }
            hour.min = Convert.ToInt16(minutos);
            Console.WriteLine("Entre com o valor da sua hora de trabalho");
            valor = float.Parse(Console.ReadLine());
            if (hour.hour != 0){
                pagamento= valor*hour.hour;
            }
            if(hour.min != 0){
               pagamento=pagamento +((hour.min/60)*valor);

            }
            Console.WriteLine($"O pagamento desse funcionário será de:{pagamento}");
        }
        
        static void Idade()
        {
            int idade;
            Console.WriteLine("Entre com a sua idade em anos");
            idade = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Você tem {idade} anos, ou {idade * 12} meses, ou {idade * 365} dias");
        }

        static void Moedas()
        {
            double valor = 0;
            double resultado = 0;
            int moeda = 0;
            Console.WriteLine("Entre com o valor em reais a ser convertido");
            valor = float.Parse(Console.ReadLine());
            Console.WriteLine("Escolha para que moeda deseja converter: \n" +
                "1 - Dolar \n" +
                "2 - Euro \n" +
                "3 - Libra Esterlina \n" +
                "4 - Dolar Canadense \n" +
                "5 - Peso Argentino \n" +
                "6 - Peso Chileno");
            moeda = Convert.ToInt16(Console.ReadLine());
            if (moeda == 1)
            {
                resultado = Math.Round(valor / 4.87, 2);
                Console.WriteLine($"{valor.ToString("N2")} reais equivale a {resultado} dolares");
            }
            else if (moeda == 2)
            {
                resultado = Math.Round(valor / 5.21, 2);
                Console.WriteLine($"{valor.ToString("N2")} reais equivale a {resultado} euros");
            }
            else if (moeda == 3)
            {
                resultado = Math.Round(valor / 6.13, 2);
                Console.WriteLine($"{valor.ToString("N2")} reais equivale a {resultado} libras esterlinas");
            }
            else if (moeda == 4)
            {
                resultado = Math.Round(valor / 3.89, 2);
                Console.WriteLine($"{valor.ToString("N2")} reais equivale a {resultado} dolares canadenses");
            }
            else if (moeda == 5)
            {
                resultado = Math.Round(valor / 0.0040, 2);
                Console.WriteLine($"{valor.ToString("N2")} reais equivale a {resultado} pesos argentinos");
            }
            else
            {
                resultado = Math.Round(valor / 0.0059, 2);
                Console.WriteLine($"{valor.ToString("N2")} reais equivale a {resultado} pesos chilenos");
            }
        }
    }
}


