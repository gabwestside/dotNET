using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioDeFixacao13 {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            RentRoom[] vect = new RentRoom[10];

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Rent #{i+1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new RentRoom(name, email);

                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms: ");
            for (int j = 0; j < 10; j++) {
                if (vect[j] != null) {
                    Console.WriteLine(j + ": " + vect[j]);
                }
            }

        }
    }
}
