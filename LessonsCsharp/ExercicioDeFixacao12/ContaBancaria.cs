using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao12 {
    class ContaBancaria {
        public int _idAccount;
        public string name;
        public string response;
        public double initialDeposit;

        public override string ToString() {
            return _idAccount
                + ", Titular: "
                + name
                + ", "
                + initialDeposit.ToString("F2", CultureInfo.InvariantCulture)
                + " deposito inicial."
                ;
        }
    }
}
