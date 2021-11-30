using System;

namespace UsingForeach {
    class Program {
        static void Main(string[] args) {
            string[] vect = new string[] { "Gab", "Dan", "Bob" };

            for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("-----------------");

            foreach (string obj in vect) {
                Console.WriteLine(obj);
            }
        }
    }
}
