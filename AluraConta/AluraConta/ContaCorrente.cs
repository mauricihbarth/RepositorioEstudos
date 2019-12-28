using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraConta
{
    class ContaCorrente : Conta
    {

        public override void Saca(double valor)
        {
            this.Saldo -= valor + 0.1;
        }

        public override void Deposita(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor + 0.1;
            }
        }
    }
}

