using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.0);		
            CalculadordeImpostos calculador = new CalculadordeImpostos();
            calculador.RealizaCalculo(orcamento,iss);

            Console.ReadKey();*/

     

            CalculadordeDescontos calculador = new CalculadordeDescontos();
            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("CANETA", 500));
            orcamento.AdicionaItem(new Item("LAPIS", 500));
            orcamento.AdicionaItem(new Item("XBOX", 500));
            orcamento.AdicionaItem(new Item("CANECA", 500));
            orcamento.AdicionaItem(new Item("GARRAFA", 500));
            orcamento.AdicionaItem(new Item("MICRO", 500));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);
            Console.ReadKey();

        }
    }
}
