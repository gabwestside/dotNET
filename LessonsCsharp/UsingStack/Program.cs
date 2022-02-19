using System;
using System.Collections.Generic;

namespace UsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            // var operationHistoric = new OperationHistoric("Gab");

            Stack<string> task = new Stack<string>();
            task.Push("Meditate");
            task.Push("See College Class");
            task.Push("Study about Data Structures");
            task.Push("Pratice English");

            task.Pop();

            // operationHistoric.Undo();

            // operationHistoric.LastOperationReturn();

            int count = task.Count;
            Console.WriteLine(count);

            foreach (string tasks in task)
            {
                Console.WriteLine(tasks);
            }

            Console.ReadLine();
        }
    }
}