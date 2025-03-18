using System;

using System.Globalization;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] arg)
        {
            double Nota1, Nota2, NotaFinal;

            Console.WriteLine("Digite a primeira nota e a segunda nota do aluno!");
            Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            NotaFinal = Nota1 + Nota2;

            Console.WriteLine("Notal Final = " + NotaFinal.ToString("F2", CultureInfo.InvariantCulture));

            if ( NotaFinal > 60.00 )
            {
                Console.WriteLine("Aluno aprovado");
            }else
            {
                Console.WriteLine("Aluno reprovado");
            }
            Console.ReadLine();
        }
    }
}