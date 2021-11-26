using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao10 {
    class Aluno {
        public string name;
        public double grade1, grade3, grade2;

        public double FinalGrade() {
            return grade1 + grade2 + grade3;
        }

        public bool Aproved() {
            if (FinalGrade() >= 60.0) {
                return true;
            } else {
                return false;
            }
        }

        public double NeededGrade() {
            if (Aproved()) {
                return 0.0;
            } else {
                return 60.0 - FinalGrade();
            }
        }
    }
}