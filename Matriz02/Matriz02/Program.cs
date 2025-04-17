using System;

namespace Matriz02
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] Mat;

            string[] s = Console.ReadLine().Split(' ');
            N = int.Parse(s[0]);
            M = int.Parse(s[1]);

            Mat = new int[M,N]; 

            //leitura da matriz e armazena numa variavel de tipo string
            for (int i= 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    Mat[i, j] = int.Parse(s[j]);
                }
            }

            //declarando um vetor para armazenar o total de linhas da matriz de M e instanciando
            int[] vet = new int[M];

            //leitura da quantidade de linhas fazendo a soma dessas linhas e inicializando como um vetor
            for (int i=0; i<M; i++)
            {
                int soma = 0;
                for (int j=0; j<N;j++)
                {
                    soma = soma + Mat[i, j];
                }
                vet[i] = soma;
            }

            for (int i=0; i<M; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}