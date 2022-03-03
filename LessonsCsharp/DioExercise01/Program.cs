using System;
using System.Globalization;

namespace DioExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;

            input = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(input[0]);
            int n1 = int.Parse(input[1]);
            double valor1 = double.Parse(input[2], CultureInfo.InvariantCulture);

            input = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);
            double valor2 = double.Parse(input[2], CultureInfo.InvariantCulture);

            double total = (n1 * valor1) + (n2 * valor2);
            Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}