using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    // public class Conta
     public abstract class Conta
    {
        public int Numero { get; private set; }

        public double Saldo { get; protected set; } //fiz da forma abaixo pois a classe que herda precisa setar

        public Cliente Titular { get; private set; }

        public abstract void Saca(double valor);

        /*public virtual void Saca(double valor)
        {
            this.Saldo -= valor;
        }*/


        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Transfere(double valor, Conta contaDestino)
        {
            this.Saldo -= valor;
            contaDestino.Saldo += valor;

        }


        public int Tipo { get; private set; }

    }
}
