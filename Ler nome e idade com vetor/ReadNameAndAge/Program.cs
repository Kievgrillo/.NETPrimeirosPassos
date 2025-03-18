﻿using System;
using System.Threading.Channels;
using System.Globalization;

namespace ReadNameAndAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            double idade1, idade2;
            double media;

            string[] vet;

            vet = Console.ReadLine().Split(' ');
            nome1 = vet[0];
            idade1 = double.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            idade2 = double.Parse(vet[1]);

            media = (double) (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade media de" + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CultureInfo.InvariantCulture ) + " anos");

            Console.ReadLine();
          
        }
    }
}