using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computer";
            string produto2 = "Table office";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo o preço é $ {preco1}", preco1.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
