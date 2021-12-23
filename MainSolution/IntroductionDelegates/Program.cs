using IntroductionDelegates.Services;
using System;

namespace IntroductionDelegates
{
    class Program
    {
        delegate double BinaryNymericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNymericOperation op = CalculationService.Max;

            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}
