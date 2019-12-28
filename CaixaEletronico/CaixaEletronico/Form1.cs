using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*double valorInvestido = 2000.00;
             for (int i = 0; i < 12; i++)
            {
                valorInvestido *= 1.01;
            }*/
            /* int i = 1;
             while ( i <= 12)
             {
                 valorInvestido *= 1.01;
                 i++;
             }

             MessageBox.Show("Valor investido é : " + valorInvestido);*/

            /*Conta umaconta = new Conta();
            umaconta.numero = 1;
            umaconta.saldo = 2000.0;
            umaconta.titular = "JOAQUIM JOSÉ";

            Conta outraconta = new Conta();
            outraconta.numero = 2;
            outraconta.saldo = 1500.0;
            outraconta.titular = "SILVA XAVIER";*/

            /*Conta guilherme = new Conta();
            guilherme.saldo = 1500.00;
  
            Conta mauricio = new Conta();
            mauricio.saldo = 1500.00;*/

            /*guilherme.Saca(200);
            guilherme.Deposita(100);*/

            /*guilherme.Transfere(300.00,mauricio);

            MessageBox.Show("O saldo atual do Guilherme é: " + guilherme.saldo);
            MessageBox.Show("O saldo atual do Mauricio é: " + mauricio.saldo);*/

            /*Conta conta = new Conta();
            Cliente cliente = new Cliente();
            conta.cliente = cliente;
            conta.numero = 123;
            cliente.nome = "VICTOR";


            MessageBox.Show("Nome do cliente da conta " + conta.numero + " é " + conta.cliente.nome);*/

            /* Cliente cliente = new Cliente("GUILHERME SILVEIRA");
             MessageBox.Show("O nome do cliente é " + cliente.Nome);*/


            /*ContaPoupanca cp = new ContaPoupanca();
            cp.Deposita(1000.00);
            cp.Saca(100.00);

            MessageBox.Show("O saldo da conta poupança é " + cp.Saldo);

            Conta contanormal = new Conta();
            contanormal.Deposita(1000.00);
            contanormal.Saca(100.00);

            MessageBox.Show("O saldo da conta normal é " + contanormal.Saldo);*/


            /*Conta c1 = new Conta();
            c1.Deposita(200);

            ContaPoupanca cp1 = new ContaPoupanca();
            cp1.Deposita(100);

            TotalizadorDeContas t1 = new TotalizadorDeContas();
            t1.Adiciona(c1);
            t1.Adiciona(cp1);

            MessageBox.Show("O totalizador é " + t1.Total);*/

            /*int[] numeros = new int[5];
            numeros[0] = 1;
            numeros[1] = 200;
            numeros[2] = 312;
            numeros[3] = -4;
            numeros[4] = 512;*/

            /*Conta[] conta = new Conta[2];
            conta[0] = new Conta();
            conta[1] = new ContaPoupanca();

            conta[0].Deposita(10);
            conta[1].Deposita(20);*/

            /*for (int i = 0; i < conta.Length; i++)
            {
                MessageBox.Show("O saldo da conta " + i + " é " + conta[i].Saldo);
            }

            foreach (Conta ct in conta)
            {
                MessageBox.Show("O saldo da conta é " + ct.Saldo);
            }*/

            //var Guilherme = new Cliente("GUILHERME");


            ContaPoupanca cp = new ContaPoupanca();
            ContaInvestimento ci = new ContaInvestimento();

            cp.Deposita(10);
            ci.Deposita(100);

            TotalizadorDeTributos tb = new TotalizadorDeTributos();
            tb.Acumula(cp);
            tb.Acumula(ci);

            MessageBox.Show("O total de tributos é " + tb.Total);
        }
    }
}
