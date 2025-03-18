using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoLogicaAtividadeF;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com seu nome completo: ");
        string FullName = Console.ReadLine();

        Console.WriteLine("Quantos quartos tem na sua casa? ");
        int quarto = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual o preço do quarto? ");
        Double preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite seu último nome, sua idade e altura na mesma linha");
        string[] vet = Console.ReadLine().Split(' ');
        string lastname = vet[0];
        int idade = int.Parse(vet[1]);
        Double altura = Double.Parse(vet[2], CultureInfo.InvariantCulture);

        Console.WriteLine(FullName);
        Console.WriteLine(quarto);
        Console.WriteLine(preco);
        Console.WriteLine("Seu ultimo nome é: " + lastname + " , "  + " sua idade: " + idade + " e " + " sua altura: " + altura );
    }
}
