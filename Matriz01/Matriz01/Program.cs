using System;

namespace Matriz01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] A;

            N = int.Parse(Console.ReadLine());
            A = new int[N,N];

            //leitura de toda a matriz
            for (int i=0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j=0; j<N;j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            //verificar os numeros da diagonal principal e exibir
            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for(int i=0; i < N; i++)
            {
                Console.WriteLine(A[i, i] + " ");
            }
            Console.WriteLine();

            //verificar quantos negativos tem na matriz
            int cont = 0;
            for(int i=0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i,j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + cont);

            Console.ReadLine();
        }
    }
}