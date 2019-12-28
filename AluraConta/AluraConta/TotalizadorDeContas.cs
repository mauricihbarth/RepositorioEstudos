﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraConta
{
    class TotalizadorDeContas
    {

        public double SaldoTotal { get; set; }

        public void Adiciona(Conta c)
        {
            this.SaldoTotal += c.Saldo;
        }

    }
}
