using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBScraper.Domain;

namespace BBScraper.App
{
    public class UsuarioApp
    {
        


        public Object AcessarDados(string agencia, string conta, string senha)
        {
            Usuario user = new Usuario(agencia, conta, senha);
            IServicoBanco servico = new ServicoBanco();


            var token =  servico.GerarToken();
            
            var cliente = servico.AcessarDadosCliente(user, token);
            
            return cliente;
        }

    }
}
