using System;

namespace ContaAlura {
    class Program {
        static void Main(string[] args) {



            Console.WriteLine("Digite o numero da conta ");
            string NumeroConta = Console.ReadLine();
            Console.WriteLine("Digite o titular da conta ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Digite o valor de depósito inicial ");
            double DepositoInicial = double.Parse(Console.ReadLine());


            ContaCorrente c1 = new ContaCorrente(NumeroConta, Nome, DepositoInicial);

            Console.WriteLine("Dados da conta ");
            Console.WriteLine(c1.ToString());

            Console.WriteLine("Entre com um valor para depósito ");

            double vlDeposito = double.Parse(Console.ReadLine());
            c1.DepositarValor(vlDeposito);
           

            Console.WriteLine("Dados da conta ");
            Console.WriteLine(c1.ToString());

            Console.WriteLine("Entre com um valor para saque ");
            double vlSaque = double.Parse(Console.ReadLine());
            c1.SacarValor(vlSaque);
            Console.WriteLine("Dados da conta ");
            Console.WriteLine(c1.ToString());

        }
    }
}
