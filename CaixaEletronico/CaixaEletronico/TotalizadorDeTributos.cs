using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class TotalizadorDeTributos
    {

        public double Total { get; private set; }

        public void Acumula(Tributavel c)
        {
            this.Total += c.CalculaTributo();
        }

        /* public void Acumula(ContaPoupanca cp)
         {
             this.Total += cp.CalculaTributo();
         }

         public void Acumula(ContaInvestimento ci)
         { 
             this.Total += ci.CalculaTributo();
         }*/
    }
}
