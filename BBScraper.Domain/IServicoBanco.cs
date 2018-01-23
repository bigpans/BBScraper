using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BBScraper.Domain
{
    public interface IServicoBanco
    {
        string GerarToken();
        Object AcessarDadosCliente(Usuario user, string token);
        string VerificarSaldo(string token);
        string VerificarExtrato();
    }
}
