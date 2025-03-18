using System;
using System.Globalization;

namespace AreaDoRetangulo
{
    class Program
    {
        static void Main(string[]args) {

            double B, A, Perimentro, Diagonal, area;


            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = B * A;
            Perimentro = 2 * (B + A);
            Diagonal = Math.Sqrt(Math.Pow(B, 2.0) + Math.Pow(A, 2.0));

            Console.WriteLine("Area =" + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro =" + Perimentro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal =" + Diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}

