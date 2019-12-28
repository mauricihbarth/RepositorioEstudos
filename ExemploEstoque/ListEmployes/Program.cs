using System;
using System.Collections.Generic;

namespace ListEmployes {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Quantos funcionários você quer adicionar");
            int qtEmploye = int.Parse(Console.ReadLine());

            List<Employe> list = new List<Employe>();

            for (int i = 0; i < qtEmploye; i++) {

                Console.WriteLine("Digite o ID do funcionário " + (i + 1));
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Name do funcionário " + (i + 1));
                string name = Console.ReadLine();
                Console.WriteLine("Digite o Salary do funcionário " + (i + 1)         );
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employe { Id = id, Name = name, Salary = salary } );

            }

            Console.WriteLine("Deseja o Id de quem você vai aumentar o salário? ");

            int idEscolhido = int.Parse(Console.ReadLine());

            Employe empregadoEscolhido = list.Find(x => x.Id == idEscolhido);

            if (empregadoEscolhido != null) {

                Console.WriteLine("Digite a porcentagem de aumento!");
                empregadoEscolhido.IncrementarSalario(double.Parse(Console.ReadLine()));
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employe obj in list) {
                Console.WriteLine(obj);
            }














        }
    }
}
