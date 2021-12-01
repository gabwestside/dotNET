using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao08 {
    class Funcionario {
        public string name;
        public double salary;
        public double tax;

        public double SalarioLiquido() {
            return salary - tax;
        }

        public double AumentarSalario(double per) {
            return salary = salary + (salary * per / 100.0);
        }

        public override string ToString() {
            return name
                + ", $"
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
