using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Gabriel, welcome back!");
            Console.Write("I need, your password: ");
            string password = Console.ReadLine();

            if (password == "@senha0114")
            {
                Console.WriteLine("Access Accepted! Its good you be here");
            }
            else
            {
                Console.WriteLine("Access Denied! Try again");
            }

            // Console.Write($"Your password is {password}");
        }
    }
}