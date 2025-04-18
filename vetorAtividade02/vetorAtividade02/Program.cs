﻿using System;
using System.Globalization;

namespace vetorAtividade02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] A;

            N = int.Parse(Console.ReadLine());

            A = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                A[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for(int i=0; i<0; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();

            double soma = 0.0;
            for(int i=0; i < N; i++)
            {
                soma = soma + A[i];
            }
            double media = soma / N;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}