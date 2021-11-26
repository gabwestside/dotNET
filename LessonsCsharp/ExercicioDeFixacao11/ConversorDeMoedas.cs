using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao11 {
    class ConversorDeMoedas {
        public static double IOF = 6.0;

        public static double Convertion(double quotation, double getDollar) {
            double total = getDollar * quotation;
            return total + total * IOF / 100.0;
        }
    }
}
