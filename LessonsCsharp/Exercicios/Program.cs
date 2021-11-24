using System;
using System.Globalization;

namespace Exercicios {
    class Program {
        static void Main(string[] args) {

            string produto1 = "Computer";
            string produto2 = "Table office";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo o preço é $ {preco1}", preco1.ToString("F2"));
            Console.WriteLine(produto2 + ", cujo preço é $ " + preco2);

            Console.WriteLine();

            Console.Write("Registro: ");
            Console.WriteLine(idade + " anos de idade, código " + codigo + " e gênero: " + genero);

            Console.WriteLine();

            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondando (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine($"Separador decimal invariant culture: {medida}", medida.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
