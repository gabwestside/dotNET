using System;
using System.Globalization;

namespace ExercicioDeFixacao8 {
    class Program {
        static void Main(string[] args) {
            Funcionario officer = new Funcionario();

            Console.Write("Nome: ");
            officer.name = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            officer.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            officer.tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Funcionário: " + officer);

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double increase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            officer.AumentarSalario(increase);
            Console.WriteLine();

            Console.Write("Dados atualizados: " + officer);
        }
    }
}
