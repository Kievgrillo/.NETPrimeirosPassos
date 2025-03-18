using System;

namespace ImplementadoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, Soma;

            N = int.Parse(Console.ReadLine());
            
            Soma = 0;
            for (int i = 1; i <= N; i++)
            {
                X = int.Parse(Console.ReadLine());
                Soma = Soma + X;
            }
            Console.WriteLine(Soma);
            Console.ReadLine();
        }
    }
}