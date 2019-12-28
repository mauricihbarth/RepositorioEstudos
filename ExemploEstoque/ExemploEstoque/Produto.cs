using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExemploEstoque {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade) {
            Quantidade +=quantidade;
        }

        public override string ToString() {
            return Nome + " com preço " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                   " Quantidade " + Quantidade +
                   " Total em estoque de " +  ValorTotalEmEstoque(); 

        }

    }
}
