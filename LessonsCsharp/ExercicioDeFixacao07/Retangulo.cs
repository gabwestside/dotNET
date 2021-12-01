using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao07 {
    class Retangulo {
        public double width;
        public double height;

        public double Area() {
            return height * width;
        }

        public double Perimetro() {
            return (2 * height) + (2 * width);
        }

        public double Diagonal() {
            double d = (height * height) + (width * width);
            d = Math.Sqrt(d);
            return d;
        }
    }
}
