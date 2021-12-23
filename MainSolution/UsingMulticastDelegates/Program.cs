using System;
using UsingMulticastDelegates.Services;

namespace UsingMulticastDelegates
{
    class Program
    {
        delegate void BinaryNymericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNymericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
        }
    }
}
