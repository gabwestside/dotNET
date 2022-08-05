using System;

namespace Delegates
{
    class Program
    {
        delegate int Calculate(int a, int b);

        static void Main(string[] args)
        {
            Calculate calculate = new Calculate(Sum);
            int sum = calculate(10, 20);

            Calculate calculate1 = new Calculate(Subtract);
            int sub = calculate1(25, 5);
            /*
                var sum = Sum(10, 20);
            */

            /*
                var sub = Subtract(20, 10);
            */

            Console.WriteLine($"Sum = {sum}\nSub = {sub}");

            Console.ReadKey();
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
