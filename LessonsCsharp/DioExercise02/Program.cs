using System;
using System.Globalization;

namespace DioExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, AVG;
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AVG = (A * 0.2) + (B * 0.3) + (C * 0.5);

            Console.WriteLine("MEDIA = {0:F1}", AVG.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}