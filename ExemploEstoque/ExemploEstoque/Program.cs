using System;
using System.Globalization;

namespace ExemploEstoque {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto();
            double valorTotalEstoque;
            Console.WriteLine("Entre os dados do produto!");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            valorTotalEstoque = p.ValorTotalEmEstoque();
            Console.WriteLine(p);

            Console.WriteLine("Adicionar produtos "); ;
            int qtde = int.Parse(Console.ReadLine());

            p.AdicionarProduto(qtde);

            Console.WriteLine("Total de produtos apos adição " + p.Quantidade.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
