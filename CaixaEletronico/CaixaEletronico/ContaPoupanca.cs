using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace CaixaEletronico
{
    class ContaPoupanca : Conta, Tributavel
    {
        public override void Saca(double valor)
        {
            this.Saldo -= valor + 0.1;
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.2;
        }


    }
}
