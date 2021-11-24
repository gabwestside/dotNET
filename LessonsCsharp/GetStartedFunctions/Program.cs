using System;

namespace GetStartedFunctions {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Escreva três números: ");
            //int value1 = int.Parse(Console.ReadLine());
            //int value2 = int.Parse(Console.ReadLine());
            //int value3 = int.Parse(Console.ReadLine());

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            //if (value1 > value2 && value1 > value3) {
            //    Console.WriteLine("Maior = " + value1);
            //}
            //else if (value2 > value3) {
            //    Console.WriteLine("Maior = " + value2);
            //}
            //else {
            //    Console.WriteLine("Maior = " + value3);
            //}

            double resultado = Maior(a, b, c);
            Console.WriteLine("Maior = " + resultado);
        }

        static int Maior(int a, int b, int c) {
            int m;
            if (a > b && a > c) {
                m = a;
            }
            else if (b > c) {
                m = b;
            }
            else {
                m = c;
            }
            return m;
        }
    }
}
