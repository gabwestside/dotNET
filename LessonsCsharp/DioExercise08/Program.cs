using System;

namespace DioExercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split();

            //Insira o seu código aqui
            int N = int.Parse(v[0]);
            int L = int.Parse(v[1]);

            int P = N * L;

            Console.WriteLine(P);
        }
    }
}