using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace AddProductClass {
    class Produto {
        public string name;
        public double price;
        public int qtd;

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
