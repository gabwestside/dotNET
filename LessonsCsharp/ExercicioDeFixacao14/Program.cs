using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioDeFixacao14 {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Empolyee #{i+1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));

                Console.WriteLine();
            }

            //Console.Write("Enter the employee id that will have salary increase: ");
            //double salaryIncrease = double.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Enter the percentage: ");
            //double per = double.Parse(Console.ReadLine());

            Console.WriteLine("Update list of employees:");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }

        }
    }
}
