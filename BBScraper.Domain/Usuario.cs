using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBScraper.Domain
{
    public class Usuario
    {

        public Usuario(string agencia, string conta, string senha)
        {
            this.Agencia = agencia;
            this.Conta = conta;
            this.Senha = senha;
        }


        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string Senha { get; set; }

    }
}
