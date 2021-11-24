using System;
using System.Globalization;

namespace ExercicioDeFIxacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int bedroom = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");
            string[] union = Console.ReadLine().Split(' ');
            string nickname = union[0];
            int age = int.Parse(union[1]);
            double height = double.Parse(union[2]);

            Console.WriteLine("\nSuas respostas: ");
            Console.WriteLine(name);
            Console.WriteLine(bedroom);
            Console.WriteLine(price);

            Console.WriteLine(nickname);
            Console.WriteLine(age);
            Console.WriteLine(height);

        }
    }
}
