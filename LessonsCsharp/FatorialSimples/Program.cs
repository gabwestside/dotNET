using System;

namespace FatorialSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, factorial, count;

            count = 0;
            factorial = 1;

            Console.Write("Digite um numero para verificarmos o seu fatorial: ");
            number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Apenas numero positivos.");
            }
            else if ((number == 0) || (number == 1))
            {
                Console.WriteLine("Fatorial de {0} é 1", number);
            }
            else
            {
                for (count = number; count >= 1; count--)
                {
                    factorial = factorial * count;
                }
                Console.WriteLine($"\nfactorial de {number} é {factorial} ");
            }
        }
    }
}