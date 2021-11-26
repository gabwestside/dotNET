using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao10 {
    class Aluno {
        public string name;
        public double grade1;
        public double grade2;
        public double grade3;

        public double FinalGrade() {
            return grade1 + grade2 + grade3;
        }

        public double NeededGrade() {
            double grade = FinalGrade() - 90.00;
            return grade;
        }
    }
}