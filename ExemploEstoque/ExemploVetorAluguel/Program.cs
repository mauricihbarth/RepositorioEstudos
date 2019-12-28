using System;
using System.Globalization;

namespace ExemploVetorAluguel {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());       

            Quarto[] q = new Quarto[10];

            for (int i = 0; i <= n; i++) {
                Console.WriteLine("Digite o nome "); 
                string name = Console.ReadLine();
                Console.WriteLine("Digite o email ");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o quarto ");
                int numeroquarto = int.Parse(Console.ReadLine()); 
                q[numeroquarto] = new Quarto { NomeCliente = name,  Numero = numeroquarto, Email = email };

            }


            for (int i = 0; i < q.Length; i++) {
                if (q[i] != null) {
                    Console.WriteLine("Nome " + q[i].NomeCliente.ToString() +
                                        " Email " + q[i].Email.ToString() +
                                        "Quarto " + q[i].Numero.ToString());
                }
            }



        }
    }
}
