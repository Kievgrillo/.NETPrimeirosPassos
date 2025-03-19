using System;
using System.Globalization;

namespace Atividade7
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            char repetir;

            do
            {
                Console.WriteLine("Digite a temperatura em Celsius:");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5 + 32;
                Console.WriteLine("Equivalente em Fahrenheit:" + F.ToString("F1"), CultureInfo.InvariantCulture);
                Console.WriteLine("Deseja repetir (s/n)?");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');

            Console.ReadLine();
        }
    }
}