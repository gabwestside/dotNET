using System;
using System.Globalization;
namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] vect = new Student[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i + 1}");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Student(name, email);
                Console.WriteLine();
            }

            Console.WriteLine("Rented Rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }

}