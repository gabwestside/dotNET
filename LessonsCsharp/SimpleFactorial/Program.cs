using System;

namespace SimpleFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, factorial, count;

            count = 0;
            factorial = 1;

            number = int.Parse(Console.ReadLine());

            for (count = number; count >= 1; count--)
            {
                factorial = factorial * count;
            }

            Console.WriteLine(factorial);
        }
    }
}