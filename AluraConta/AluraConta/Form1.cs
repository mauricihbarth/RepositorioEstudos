using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluraConta
{
    public partial class Form1 : Form
    {
        Conta[] contas;
        public Form1()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {

            int itemSelecionadoOrigem = comboContas.SelectedIndex;
            int itemSelecionadoDestino = comboDestino.SelectedIndex;


            Conta contaSelecionadaOrigem = contas[itemSelecionadoOrigem];
            Conta contaSelecionadaDestino = contas[itemSelecionadoDestino];

            contaSelecionadaOrigem.Transfere(contaSelecionadaDestino,100.00);


            textoSaldo.Text = Convert.ToString(contaSelecionadaOrigem.Saldo);


            /*Conta t1 = new Conta();
            t1.titular = "Ze da breja";
            t1.cpf = "07612398982";
            t1.agencia = 1;

            MessageBox.Show("Os dados do titular são  Nome = " + t1.titular+ 
                            " CPF = " + t1.cpf + 
                            " Agencia = " + t1.agencia);*/

            /*Conta conta = new Conta();
            Cliente cliente = new Cliente("JAMES","23435");
            conta.Titular = cliente;

            MessageBox.Show("Nome = " + conta.Titular.Nome + " e seu RG é " + conta.Titular.Rg);


            cliente.Nome = "Victor";
            cliente.Idade = 17;
            conta.Titular.Rg = "12325";
            conta.Deposita(2000.0);

            if (conta.Saca(201.0))
            {
                MessageBox.Show("Dinheiro sacado com sucesso !");
            }
            else
            {
                MessageBox.Show("Saque inválido !");
            }*/


            /*  Conta conta = new Conta();
            conta.Titular.Nome = "José";
            conta.Numero = 1;
            conta.Deposita(250.0);
            textoTitular.Text = conta.Titular.Nome;
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            //textoValor.Text = "0";

            if (textoValor.Text != "")
            {
                conta.Saca(Convert.ToDouble(textoValor.Text));
            }

            textoSaldo.Text = Convert.ToString(conta.Saldo);*/

            /*ContaPoupanca cp = new ContaPoupanca();
            Cliente cliente = new Cliente("JAMES", "23435");
            cp.Titular = cliente;

            cp.Deposita(250);

            textoSaldo.Text = Convert.ToString(cp.Saldo) ;*/


            /*ContaPoupanca cp = new ContaPoupanca();
            ContaCorrente cc = new ContaCorrente();

            cp.Deposita(100);
            cc.Deposita(200);

            TotalizadorDeContas t1 = new TotalizadorDeContas();
            t1.Adiciona(cp);
            t1.Adiciona(cc);

            textoTotalizador.Text = Convert.ToString(t1.SaldoTotal);*/


            /*Conta[] contas = new Conta[2];

            contas[0] = new Conta();
            contas[1] = new ContaPoupanca();

            contas[0].Deposita(100.0);
            contas[1].Deposita(250.0);

            foreach (Conta conta in contas)
            {
                MessageBox.Show("O saldo " + conta.Saldo);
            }*/





        }

        private void Form1_Load(object sender, EventArgs e)
        {

            contas = new Conta[2];

            Conta contaDoVictor = new Conta();
            contaDoVictor.Titular.Nome = "Victor";
            contaDoVictor.Numero = 1213;
            contaDoVictor.Deposita(500);

            Conta contaDoMario = new Conta();
            contaDoMario.Titular.Nome = "Mario";
            contaDoMario.Numero = 2;
            contaDoMario.Deposita(1500);

            contas[0] = contaDoVictor;
            contas[1] = contaDoMario;


            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular.Nome);
            }

            foreach (Conta conta in contas)
            {
                comboDestino.Items.Add(conta.Titular.Nome);
            }

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemSelecionado = comboContas.SelectedIndex;

            Conta contaSelecionada = contas[itemSelecionado];

            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoTitular.Text = contaSelecionada.Titular.Nome;


        }

        private void labelContas_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ContaPoupanca cp = new ContaPoupanca();
            ContaInvestimento ci = new ContaInvestimento();
            SeguroDeVida sv = new SeguroDeVida();
            cp.Deposita(100);
            ci.Deposita(100);

            /* TotalizadorDeTributos t1 = new TotalizadorDeTributos();
             t1.Acumula(cp);
             t1.Acumula(ci);*/

            GerenciadorDeImposto g1  = new GerenciadorDeImposto();
            g1.Adiciona(cp);
            g1.Adiciona(ci);
            g1.Adiciona(sv);



            //t1.Acumula(new ContaCorrente()); Não via deixar pois conta não é do tipo tributavek

            MessageBox.Show("O total de tributos é " +  g1.Total);

        }
    }
}
