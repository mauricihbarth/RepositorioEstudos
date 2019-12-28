using System;
using System.Collections.Generic;
using System.Text;

namespace ContaAlura {
    class ContaCorrente {

        public string Numero { get; private set; }
        public string NomeTitular { get; private set; }  
        public double Valor { get; private set; }

        public ContaCorrente() {
        }

        public ContaCorrente(string numeroConta, string nomeTitular,
                            double valorInicial) {
            Numero = numeroConta;
            NomeTitular = nomeTitular;
            Valor = valorInicial;
        }

        public void DepositarValor(double valor) {
            Valor += valor;
        }

        public void SacarValor(double valor) {
            Valor -= valor;
        }

        public override string ToString() {
            return "Conta " + Numero +
                    " Titular " + NomeTitular +
                    " Total em conta " + Valor;
        }

    }
}
