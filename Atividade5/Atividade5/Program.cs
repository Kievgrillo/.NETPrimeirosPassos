using System;

using System.Globalization;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            double PlanoBasico;

            minutos = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            PlanoBasico = 50.0;

            if (minutos > 100)
            {
                //PlanoBasico = PlanoBasico + (minutos - 100) * 2.0 mesma coisa que que a linha de baixo;
                PlanoBasico += (minutos - 100) * 2.0;
                Console.WriteLine("Valor a pagar: R$ " + PlanoBasico.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (PlanoBasico < 100)
            {
                Console.WriteLine("Valor a pagar: R$ " + PlanoBasico);
            }
            Console.ReadLine();
        }
    }
}