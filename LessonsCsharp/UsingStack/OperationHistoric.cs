using System;
using System.Collections.Generic;

namespace UsingStack
{
    class OperationHistoric
    {
        public string UserName { get; private set; }
        private Stack<string> _historic;

        public OperationHistoric(string userName)
        {
            UserName = userName;

            _historic = new Stack<string>();
        }

        public void Add(string name)
        {
            _historic.Push(name);
        }

        public void Undo()
        {
            Console.WriteLine($"Undo last operation.");

            _historic.Pop();
        }

        public string LastOperationReturn()
        {
            var lastOperation = _historic.Peek();

            return lastOperation;
        }
    }
}