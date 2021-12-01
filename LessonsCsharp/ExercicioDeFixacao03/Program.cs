using System;

namespace ExercicioDeFixacao03 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um numero inteiro entre 1 e 100: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
