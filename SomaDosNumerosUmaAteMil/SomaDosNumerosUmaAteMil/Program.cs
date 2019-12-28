using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDosNumerosUmaAteMil
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int valor = 0; 

            for (int i = 1; i <= 1000; i++)
            {
                valor += i;
            }*/



            /* for (int i = 1; i <= 100; i++)
             {
                 if (i % 3 == 0)
                 {
                     Console.WriteLine("Numero  " + i + "é multiplo de 3!");
                 }
             }*/

            /*int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial = (fatorial) *(n- fatorial);

                Console.WriteLine("O fator de " + n + " é " + fatorial);

            }*/




            /*int n1 = 1;
            int nanterior = 0;
            //string serieFibonacci = "";
            Console.WriteLine(n1);

            while (n1<=100)
            {
                n1 = nanterior + n1;
                Console.WriteLine(n1);

                nanterior = n1 - nanterior;

            }*/

            /*int n1 = 1;
            int nanterior = 0;
            string serieFibonacci = "";
            //Console.WriteLine(n1);

            while (n1<=100)
            {
                serieFibonacci = serieFibonacci + n1 + " ";

                n1 = nanterior + n1;
                
                nanterior = n1 - nanterior;
            }

            Console.WriteLine("Serie de fibonacci ficou com sequencia " + serieFibonacci);


            string serieFibonacci = "";
            int anterior = 0;
            int atual = 1;
            while (atual <= 100)
            {
                serieFibonacci += atual + " ";
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
            Console.WriteLine("A série de Fibonacci até 100: " + serieFibonacci);*/

            /*string mensagem = "";  // FOR ENCADEADO

            for (int linha = 1; linha <= 4; linha++)
            {

                for (int coluna = 1; coluna <= linha; coluna++)
                {
                    mensagem = mensagem + (linha * coluna) +  " " ;
                }
                mensagem += "\n";
            }

            Console.WriteLine(mensagem); */

            /*//Operadores escreva primeiro o código que verifica se o número 15 é divisível por 3 ou por 4

            int numero = 5;
            double resultado = 0.00;
            int divisor = 15;


            if (divisor % 3 == 0)
            {
                Console.Write("O divisor " + divisor + " é divisível por " + 3);

            }
            else if (divisor % 4 == 0)
            {
                Console.Write("O divisor " + divisor + " é divisível por " + 4);
            }
            else
            {
                Console.Write("O divisor " + divisor + " não é divisível por nenhum desses números");
            }*/

            /*//depois disso adapte o programa para imprimir todos os números entre 0 e 30 que são divisíveis por 3 ou 4.

            String mensagem = "";
            String mensagemDivididospor3 = "";
            String mensagemDivididospor4 = "";

            for (int divisor = 0; divisor < 30; divisor++)
            {
                if (divisor % 3 == 0)
                {
                    mensagemDivididospor3 += divisor + " ";
                }
                else if (divisor % 4 == 0)
                {
                    mensagemDivididospor4 += divisor + " ";
                }
            }

            mensagem += "Os divisores por 3 são " + mensagemDivididospor3 + "\n" +
                       "Os divisores por 4 são " + mensagemDivididospor4;

            Console.WriteLine(mensagem);*/

            /*//Escreva um programa em C# que some todos os números de 1 a 100, pulando os múltiplos de 3. O programa deve imprimir o resultado final em um MessageBox.
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    soma += i;
                }                
            }

            Console.WriteLine("A soma total é " + soma);*/




            Console.ReadKey();

        }
    }
}