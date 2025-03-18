using System;

using System.Globalization;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            double MenorValor;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0], CultureInfo.InstalledUICulture);
            y = int.Parse(vet[1], CultureInfo.InstalledUICulture);
            z = int.Parse(vet[2], CultureInfo.InstalledUICulture);

            if (x < y && x < z)
            {
                Console.WriteLine("MENOR = " + x);
            }
            else if (y < z)
            {
                Console.WriteLine("MENOR = " + y);
            }
            else
            {
                Console.WriteLine("MENOR = " + z);
            }
        }
    }
}