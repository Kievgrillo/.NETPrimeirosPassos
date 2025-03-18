using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace CursoLogica.ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {


            //ler um numero inteiro
            //Ler um numero double
            //Ler um caractere
            //Ler um nome, sexo(caractere F ou M), idade (inteiro) e altura(Double) na mesma linha, armazenando-os em quatro var com os devidos tipos

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            Console.WriteLine("Voce digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

