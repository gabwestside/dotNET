using System;

namespace ExerciciosDeFixação2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantas numeros inteiros vc vai digitar? ");
            int numberLenght = int.Parse(Console.ReadLine());

            int soma = 0;

            for(int i = 0; i < numberLenght; i++) {
                Console.Write("Valor #{0}: ", i);

                int valor = int.Parse(Console.ReadLine());

                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);
        }
    }
}
