using System;
using System.Globalization;

namespace CalcularLarguraDoTerreno
{
    class Progrram
    {
        static void Main(string[] args)
        {
            double Largura, Comprimento, PrecoMetroQuadrado, Area, ValorTotal;

            Console.WriteLine("Digite a largura do terreno:");
            Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o comprimento do terreno:");
            Comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor do metro quadrado:");
            PrecoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = Largura * Comprimento;
            ValorTotal = PrecoMetroQuadrado * Area;

            Console.WriteLine("Area = " + Area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preco = " + ValorTotal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}