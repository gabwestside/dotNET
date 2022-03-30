using System;
using System.Globalization;

namespace DioExercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstGrade, secondGrade, response = 1;

            while (response == 1)
            {
                firstGrade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (firstGrade < 0 || firstGrade > 10)
                {
                    Console.WriteLine($"nota invalida");

                    firstGrade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                secondGrade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (secondGrade < 0 || secondGrade > 10)
                {
                    Console.WriteLine($"nota invalida");

                    secondGrade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double avg = (firstGrade + secondGrade) / 2;

                Console.WriteLine($"media = {avg.ToString("F2", CultureInfo.InvariantCulture)}");

                Console.WriteLine($"novo calculo (1-sim 2-nao)");

                response = int.Parse(Console.ReadLine());

                while (response != 1 && response != 2)
                {
                    Console.WriteLine($"novo calculo (1-sim 2-nao)");

                    response = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
