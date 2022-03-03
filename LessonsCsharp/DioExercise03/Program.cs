using System;

namespace DioExercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int result = i * n;
                Console.WriteLine(string.Format($"{i} x {n} = {result}"));
            }
        }
    }
}