using System;

namespace WhileLessons {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite sua senha: ");
            string password = Console.ReadLine();

            Console.WriteLine();

            while (password != "0114") {
                Console.WriteLine("Senha inválida!");
                Console.Write("Digite uma senha válida: ");
                password = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
