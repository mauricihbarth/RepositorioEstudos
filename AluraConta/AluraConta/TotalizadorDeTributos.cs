using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraConta
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumula (ITributavel ct) //Vai passar aqui a conta que é tributavel
        {
            this.Total += ct.CalculaTributo();
        }



    }
}
