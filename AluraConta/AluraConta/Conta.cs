using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraConta
{
    public class Conta
    {
        public double Saldo { get; protected set; }
        public int Numero { get; set; }
        public string Cpf { get; set; }
        public int Agencia { get; set; }
        public Cliente Titular { get; set; }

        public Conta ()
        {
            this.Titular = new Cliente("");
        }

        public virtual void Saca(double valor)
        {

            this.Saldo -= valor + 0.1;
            /* bool sacou = false;
             if ((valor > 0) && (this.Saldo >= valor))
             {
                 if (Titular.EhMaiorDeIdade())
                 {
                     this.Saldo -= valor;
                     sacou = true;
                 }
                 else

                     if (valor < 200)
                 {
                     this.Saldo -= valor;
                     sacou = true;
                 }

             }
             return sacou;*/



        }

        public virtual void Deposita(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }
        }

        public void Transfere(Conta contaDestino, double valor)
        {
            //this.saldo = this.saldo - valor;
            //contaDestino.saldo += valor;

            this.Saca(valor);
            contaDestino.Deposita(valor);

        }

    }

}