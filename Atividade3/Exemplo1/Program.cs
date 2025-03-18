using System;

using System.Globalization;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;

            Console.WriteLine("quantas horas ?");
            horas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (horas > 12)
            {
                Console.WriteLine("Boa tarde");
            } 
            else
            {
                Console.WriteLine("Bom dia");
            }

            Console.ReadLine();
        }
    }
}