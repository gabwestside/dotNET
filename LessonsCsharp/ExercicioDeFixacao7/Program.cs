using System;

namespace ExercicioDeFixacao7 {
    class Program {
        static void Main(string[] args) {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e a altura do retangulo:");
            retangulo.width = double.Parse(Console.ReadLine());
            retangulo.height = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + retangulo.Area());
        }
    }
}
