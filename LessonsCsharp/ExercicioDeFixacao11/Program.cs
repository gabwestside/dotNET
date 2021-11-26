using System;
using System.Globalization;

namespace ExercicioDeFixacao11 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual a cotação do dolar? ");
            double quotation = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares deseja comprar? ");
            double getDollar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoedas.Convertion(quotation, getDollar);

            Console.Write("Valor a ser pago em reais = " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
