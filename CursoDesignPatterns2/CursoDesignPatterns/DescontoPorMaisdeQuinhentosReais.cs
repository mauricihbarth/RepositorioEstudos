﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class DescontoPorMaisde500Reais : Desconto
    {
        public Desconto Proximo { get; set; }
	
	public double Desconta(Orcamento orcamento)
        {

            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.1;
            }
            return Proximo.Desconta(orcamento);
        }
    }
}
