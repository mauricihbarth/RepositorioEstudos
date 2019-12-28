using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCollections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a classe Aula";
            string aulaSets = "Trabalhando em conjuntos";
            //Primeira forma de declarar array quando eu sei desde começo os elementos que ele vai ter
            //string[] aulas = new string[]
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            //Segunda forma de declarar array quando eu sei desde começo os elementos que ele vai ter
            string[] aulas = new string[3];

            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            //Imprimir(aulas);

            //MessageBox.Show("Aula modelando está no indice " + Array.IndexOf(aulas, aulaModelando));

            //Array.Reverse(aulas);//Reverter os indices, fica tudo ao contrário

            Array.Resize(ref aulas, 2); //redimensinar o array, alterar a capacidade de indice dele
            Array.Resize(ref aulas, 3); //redimensinar o array, alterar a capacidade de indice dele

            aulas[aulas.Length - 1] = "Conclusão";

            Array.Sort(aulas);//Ordena pela descrição, não tem como reverter


            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2); //vai copiar as 2 ultimas posições do aulas para um novo array chamado copia


            string[] clone = aulas.Clone() as string[]; // vai clonar o array. no final tem que converter para um array de string

            Array.Clear(clone, 1, 2); // limpando os 2 ultimos elementos de array de clone

            Imprimir(clone);

            //Array não é muito utilizado para coleção, o List sempre é mais recomendado.
            //Utilizar array utilizado mais para transferencia de arquivo, manipulação de buffer, de imagem ou arquivos de baixo nivel
            //Utilizar mais List pous fornece maior gama de métodos, mas facil de travalhar,.
            //Array é o tipo de coleção mais básica do .net framework


        }

        private static void Imprimir(string[] aulas)
        {
            string mensagem = "";
            //foreach (var aula in aulas)
            //{
            //    mensagem += aula + "\n";
            //}

            for (int i = 0; i < aulas.Length; i++)
            {
                mensagem += aulas[i] + "\n";
            }

            MessageBox.Show(mensagem);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a classe Aula";
            string aulaSets = "Trabalhando em conjuntos";

            //List<string> aulas = new List<string>
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            List<string> aulas = new List<string>();

            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            aulas.First(aula >= aula.Contains("Conclusão"));

            Imprimir(aulas);

        }

        private static void Imprimir(List<string> aulas)
        {
            string mensagem = "";

            //foreach (var aula in aulas)
            //{
            //    mensagem += aula + '\n';
            //}
            //for (int i = 0; i < aulas.Count; i++)
            //{
            //        mensagem += aulas[i] + '\n';
            //}

            //COM LAMBDA
            aulas.ForEach(aula =>
            {
                mensagem += aula + '\n';
            }

                                );

            MessageBox.Show(mensagem);
        }
    }
}

