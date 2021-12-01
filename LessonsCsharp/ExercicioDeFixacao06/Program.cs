using System;
using System.Globalization;

namespace ExercicioDeFixacao6 {
    class Program {
        static void Main(string[] args) {
            Funcionario officer1, officer2;

            officer1 = new Funcionario();
            officer2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            officer1.name = Console.ReadLine();
            Console.Write("Salário: ");
            officer1.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            officer2.name = Console.ReadLine();
            Console.Write("Salário: ");
            officer2.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double avg = (officer1.salary + officer2.salary) / 2;

            Console.Write("Salário médio = $" + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
