using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBScraper.Domain
{
    public static class Destinos
    {
        public static string Token
        {
            get
            {
                return @"https://mobi.bb.com.br/mov-centralizador/hash"; 
            
             }
        }

        public static string Login
        {
            get
            {
                return @"https://mobi.bb.com.br/mov-centralizador/servico/ServicoLogin/login";

            }
        }

        public static string Saldo
        {
            get
            {
                return @"https://mobi.bb.com.br/mov-centralizador/servico/ServicoSaldo/saldo";

            }
        }

        public static string Extrato
        {
            get
            {
                return @"https://mobi.bb.com.br/mov-centralizador/tela/ExtratoDeContaCorrente/extrato";

            }
        }

    }
}
