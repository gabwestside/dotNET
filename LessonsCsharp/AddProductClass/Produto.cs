using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace AddProductClass {
    class Produto {
        private string name;
        private double price;
        private int qtd;

        public Produto() {
            qtd = 10;
        }
        public Produto(string Name, double Price) : this() {
            name = Name;
            price = Price;
        }

        public Produto(string Name, double Price, int Qtd) : this(Name, Price) {
            qtd = Qtd;
        }


        public double ValorTotalEmEstoque() {
            return price * qtd;
        }

        public void AdicionarProdutos(int add) {
            qtd += add;
        }

        public void RemoverProdutos(int less) {
            qtd -= less;
        }

        public override string ToString() {
            return name
                + ", $"
                + price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + qtd
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
