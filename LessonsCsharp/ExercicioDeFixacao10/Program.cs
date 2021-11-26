using System;
using System.Globalization;

namespace ExercicioDeFixacao10 {
    class Program {
        static void Main(string[] args) {
            Aluno student = new Aluno();
            Console.Write("Nome do aluno: ");
            student.name = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            student.grade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.grade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.grade3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Notal Final = " + student.FinalGrade().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            
            if (student.Aproved()) {
                Console.WriteLine("Aprovado!");
            } else {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltaram " 
                    + student.NeededGrade().ToString("F2", CultureInfo.InvariantCulture) 
                    + " pontos... :(");

            }

        }
    }
}
