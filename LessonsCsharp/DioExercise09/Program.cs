using System;

namespace DioExercise09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(inicio + " " + (inicio * inicio) + " " + (inicio * inicio * inicio));
                inicio++;
            }
        }
    }
}
