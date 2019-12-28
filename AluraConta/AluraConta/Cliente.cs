using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraConta
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }
        public bool Emancipado { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente(string nome, string rg)
        {
            this.Nome = nome;
            this.Rg = rg;
        }

        public bool EhMaiorDeIdade()
        {
            if (this.Idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PodeAbrirConta()
        {
            var temRg = string.IsNullOrEmpty(this.Rg);
            var emancipado = this.Emancipado;

            if ((emancipado) &&
                    (EhMaiorDeIdade()) &&
                    (temRg))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
