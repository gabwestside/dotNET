using System;

namespace ExercicioDeFixacao00 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("----------SOMA DE DOIS VALORES----------");
            Console.WriteLine("Digite o primeiro valor e aperte ENTER:");

            int value1 = int.Parse(Console.ReadLine());
            int value2 = int.Parse(Console.ReadLine());

            int soma = value1 + value2;

            Console.WriteLine("SOMA = " + soma);

            if (soma >= 0) {
                Console.WriteLine("Seu número é positivo");
            }
            else {
                Console.WriteLine("Seu número é negativo");
            }

        }
    }
}
