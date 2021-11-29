using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao13 {
    class RentRoom {
        public string Name { get; set; }
        public string Email { get; set; }

        public RentRoom(string name, string email) {
            Name = name;
            Email = email;
        }

        public override string ToString() {
            return Name + ", " + Email;
        }
    }
}
