using System;
using System.Globalization;

namespace ExercicioDeFixacao12 {
    class Program {
        static void Main(string[] args) {
            ContaBancaria account = new ContaBancaria();

            Console.Write("Entre com o número da conta: ");
            account._idAccount = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            account.name = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            account.response = Console.ReadLine();

            Console.Write("Entre com o valor de depósito inicial ");
            account.initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados atualizados: ");
            Console.Write("Número: " + account);
        }
    }
}
