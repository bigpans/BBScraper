using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BBScraper.Domain
{
    public class Requisicao
    {
        public HttpWebRequest HttpRequest { get; set; }
        public string Url { get; set; }
        public Byte[] Post { get;  set; }

        public Requisicao()
        {
           
        }
            
        public void DefineRequest(string url)
        {
            this.HttpRequest = (HttpWebRequest)WebRequest.Create(url);
            this.HttpRequest.Method = "POST";
            this.HttpRequest.ContentType = @"application/x-www-form-urlencoded;charset=UTF-8";
            this.HttpRequest.UserAgent = @"Android;Google Nexus 5 - 6.0.0 - API 23 - 1080x1920;Android;6.0;vbox86p-userdebug 6.0 MRA58K eng.buildbot.20160110.195928 test-keys;mov-android-app;6.14.0.1;en_US;cpu=0|clock=|ram=2052484 kB|espacoSDInterno=12.46 GB|isSmartphone=true|nfc=false|camera=true|cameraFrontal=true|root=true|reconhecimentoVoz=false|resolucao=1080_1776|densidade=3.0|";
        }


    }
}
