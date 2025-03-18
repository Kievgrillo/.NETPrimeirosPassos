using System;
using System.Globalization;

namespace CursoLogicaFuncaoMatematica
{
    class Program
    {
        static void Main(string[]args)
        {
             double x = 3.0;
             double y = 4.0;
             double z = -5.0;
             double A, B, C;

             //Var recebendo raiz de quadrada de N numeros   
             A = Math.Sqrt(x);
             B = Math.Sqrt(y);
             C = Math.Sqrt(25.0);

             Console.WriteLine("Raiz quadrada de " + x + " = " + A);
             Console.WriteLine("Raiz quadrada de " + y + " = " + B);
             Console.WriteLine("Raiz quadrada de 25 " + C);

             //Var A recebendo um resultado de X elevado a Y   
             A = Math.Pow(x, y);
             B = Math.Pow(y, 2.0);
             C = Math.Pow(5.0 , 2.0);
             
             Console.WriteLine(x + " elevado a " + y + " = " + A);
             Console.WriteLine(x + " elevado ao quadrado = " + B);
             Console.WriteLine("5 elevado ao quadrado = " + C);

             //Var A recebendo um valor absoluto
             A = Math.Abs(x);
             B = Math.Abs(z);
             Console.WriteLine("Valor absoluto de " + y + " = " + A);
             Console.WriteLine("Valor absoluto de " + z + " = " + B);

             Console.ReadLine();
             




        }
    }
}
