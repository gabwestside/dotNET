using System;
using System.Globalization;

namespace LessonsCsharp {
    class Program {
        static void Main(string[] args) {
            char genero = 'F';
            double saldo = 10.34530281;
            int idade = 31;
            string nome = "Maria";

            Console.WriteLine("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(saldo);
            Console.WriteLine(idade);
            Console.WriteLine(nome);

            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F5", CultureInfo.InvariantCulture));


            // Usando placeholders

            string nome2 = "Gabriel";
            int idade2 = 24;
            double saldo2 = 1400;

            Console.WriteLine($"{nome2} tem {idade2} anos de idade, e tem R${saldo2},00 de saldo!");
        }
    }
}
