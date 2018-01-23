using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BBScraper.App;
using BBScraper.Models;

namespace BBScraper.Controllers
{
    public class HomeController : Controller
    {

        UsuarioApp usuarioApp = new UsuarioApp();

        
        public ActionResult Index()
        {
            
            return View();
        }


        [HttpPost]
        public JsonResult Index(Account  model)
        {

            var usuario = usuarioApp.AcessarDados(model.Agencia, model.Conta, model.Senha);
            
            return Json(new { usuario }, JsonRequestBehavior.AllowGet);
        }

        
        
    }
}