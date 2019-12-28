using System;
using System.Globalization;

namespace PequenosExerciciosAlura {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o número de vetores!");
            int v = int.Parse(Console.ReadLine());

            int[] vetor = new int[v];

            for (int i = 0; i < v; i++) {
                vetor[i] = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
            }

            for (int i = 0; i < vetor.Length; i++) {
                Console.WriteLine("Vetor " + i + " = "  + vetor[i].ToString());
            }

        }
    }
}
