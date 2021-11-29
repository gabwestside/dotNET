using System;
using System.Globalization;

namespace ExercicioDeFixacao12 {
    class Program {
        static void Main(string[] args) {
            ContaBancaria account;

            Console.Write("Entre com o número da conta: ");
            int idAccount = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string name = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char response = char.Parse(Console.ReadLine());

            if (response == 's' || response == 'S') {
                Console.Write("Entre com o valor de depósito inicial ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account = new ContaBancaria(idAccount, name, initialDeposit);
            } else {
                account = new ContaBancaria(idAccount, name);
            }

            Console.WriteLine("Dados atualizados: ");
            Console.Write("Número: " + account);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposito(deposit);

            Console.WriteLine("Dados atualizados: ");
            Console.Write("Número: " + account);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Saque(withdraw);

            Console.WriteLine("Dados atualizados: ");
            Console.Write("Número: " + account);
        }
    }
}
