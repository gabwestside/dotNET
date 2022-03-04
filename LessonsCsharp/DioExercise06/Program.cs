using System;

namespace DioExercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int primeiro = 1;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(primeiro + " " + (primeiro + 1) + " " + (primeiro + 2) + " PUM ");
                primeiro += 4;
            }
        }
    }
}