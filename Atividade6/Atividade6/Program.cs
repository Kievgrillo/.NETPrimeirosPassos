using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Uri1113
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, media;
            int cont;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            soma = 0.0;
            cont = 0;

            while (idade >= 0)
            {
                soma = soma + idade; //calculo para saber a idade total
                cont = cont + 1;    //consegue computador todas as idades que o programa digitar
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // para fazer o while rodar novamente
            }
            if (cont == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                media = soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }

    }
}