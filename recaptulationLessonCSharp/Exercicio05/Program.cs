using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                string[] line = Console.ReadLine().Split(" ");

                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);

                double Total = X / Y;

                string msg = "divisao impossivel";

                if (Y == 0)
                {
                    Console.WriteLine($"{msg}");
                }
                else
                {
                    Console.WriteLine($"{Total.ToString("F1")}");
                }
            }
        }
    }
}