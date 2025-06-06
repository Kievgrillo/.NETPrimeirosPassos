﻿using System;
using System.ComponentModel;
using System.Globalization;

namespace VetorAtividade03
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];

            //leitura dos dados
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                alturas[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

            }

            //calculo da idade media das pessoas
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + alturas[i];
            }
            double media = soma / N;
            Console.WriteLine("Alutra média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            //porcetagem de pessoas baixos dos 16 anos
            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    cont++;
                }
            }
            double porcentagem = (double)cont / N * 100.0;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F2", CultureInfo.InvariantCulture) + "%");

            Console.ReadLine();
        }
    }
}