using System;

namespace UsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var operationHistoric = new OperationHistoric("Gab");

            operationHistoric.Add("Meditate");
            operationHistoric.Add("See College Class");
            operationHistoric.Add("Study about Data Structures");
            operationHistoric.Add("Pratice English");

            operationHistoric.Undo();

            operationHistoric.LastOperationReturn();

            Console.ReadLine();
        }
    }
}