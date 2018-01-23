using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BBScraper.Domain
{
    public class ServicoBanco : IServicoBanco
    {
        public string Hash { get { return ""; } }
        public string Idh { get; set; }
        public string Id { get { return "00000000000000000000000000000000"; } }
        public string Apelido { get { return "000000000000000"; } }
        Requisicao request = new Requisicao();
       
      


        
        public string GerarToken()
        {
            request.DefineRequest(Destinos.Token);

            request.HttpRequest.CookieContainer = new CookieContainer();

            this.Idh = "";
            ASCIIEncoding encode = new ASCIIEncoding();
            var data = "hash=" + this.Hash + "&idh=" + this.Idh + "&id=" + this.Id + "&apelido=" + this.Apelido;
            byte[] post = encode.GetBytes(data);
            request.HttpRequest.ContentLength = post.Length;
            

            Stream stream = request.HttpRequest.GetRequestStream();
            stream.Write(post, 0, post.Length);

            stream.Close();
            

            WebResponse response = request.HttpRequest.GetResponse();
            stream = response.GetResponseStream();
            

            StreamReader reader = new StreamReader(stream);
            var token = reader.ReadToEnd();
            reader.Close();
            stream.Close();

            return token;

        }

        public Object AcessarDadosCliente(Usuario user, string token)
        {

            request.DefineRequest(Destinos.Login);

            this.Idh = token;
            var senhaConta = user.Senha;
            var dependenciaOrigem = user.Agencia;
            var numeroContratoOrigem = user.Conta;
            var idDispositivo = "";


            ASCIIEncoding encode = new ASCIIEncoding();
            var data = "idh=" + this.Idh + "&senhaConta=" + senhaConta + "&apelido=" + this.Apelido + "&dependenciaOrigem=" + dependenciaOrigem + "&numeroContratoOrigem=" + numeroContratoOrigem + "&idRegistroNotificacao&idDispositivo=" + idDispositivo + "&titularidade=1";
            byte[] post = encode.GetBytes(data);
            request.HttpRequest.ContentLength = post.Length;


            Stream stream = request.HttpRequest.GetRequestStream();
            stream.Write(post, 0, post.Length);

            stream.Close();


             WebResponse response = request.HttpRequest.GetResponse();
             stream = response.GetResponseStream();

             StreamReader reader = new StreamReader(stream);
             var dadosCliente = reader.ReadToEnd();
             reader.Close();

             return dadosCliente;
           

        }

        public string VerificarSaldo(string token)
        {
           
            ASCIIEncoding encode = new ASCIIEncoding();
            var data2 = "servico/ServicoSaldo/saldo&idh=&idDispositivo="+this.Apelido + "&apelido="+this.Apelido;
            byte[] post = encode.GetBytes(data2);
            request.DefineRequest(Destinos.Saldo);
            request.HttpRequest.ContentLength = post.Length;
            request.HttpRequest.Method = "POST";
           
            Stream stream = request.HttpRequest.GetRequestStream();
            stream.Write(post, 0, post.Length);

            stream.Close();


            WebResponse response = request.HttpRequest.GetResponse();
            stream = response.GetResponseStream();

            StreamReader reader = new StreamReader(stream);
            var saldoEmConta = reader.ReadToEnd();
            reader.Close();
            stream.Close();

            return saldoEmConta;
        }

        public string VerificarExtrato()
        {
            throw new NotImplementedException();
        }

       
    }
}
