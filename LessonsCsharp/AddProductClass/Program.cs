using System;
using System.Globalization;

namespace AddProductClass {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com os dados do produto:");

            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade em estoque: ");
            int qtd = int.Parse(Console.ReadLine());

            Produto newProduct = new Produto(name, price, qtd);

            Console.Write("Dados do produto: " + newProduct);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser adicionada: ");
            int addProd = int.Parse(Console.ReadLine());
            Console.WriteLine();
            newProduct.AdicionarProdutos(addProd);
            Console.WriteLine("Dados atualizados: " + newProduct);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser removido: ");
            int remProd = int.Parse(Console.ReadLine());
            newProduct.RemoverProdutos(remProd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + newProduct);
        }
    }
}
