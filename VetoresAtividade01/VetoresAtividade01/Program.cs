using System;

namespace VetoresAtividade01
{
    class Program
    {
        static void Main(string [] args)
        {
            int N;
            int[] Vet;

            N = int.Parse(Console.ReadLine());
            Vet = new int[N];

            string[] s = Console.ReadLine().Split(' '); //criando vetor de strings, chamando de S e ele recebe o console.readline 
            for (int i=0; i<N; i++) //
            {
                Vet[i] = int.Parse(s[i]); // o Vet na posicao I recebe o int.parse do vetor S na posicao I.
            }

            for (int i=0; i<N; i++) //criando um for para verificar os valores negativos e mostrar eles.
            {
                if (Vet[i] < 0)
                {
                    Console.WriteLine(Vet[i]);
                }
            }

            Console.ReadLine();
        }
    }
}