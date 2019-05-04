using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sirlean.Projeto001.MVC.Models;

namespace Sirlean.Projeto001.MVC.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index(TesteViewModel model = null)
        {

            //var valor = model?.Entrada;
            //var test = string.IsNullOrEmpty(valor);
            //if (test == false)

            //var valor = model?.Entrada;
            //if (string.IsNullOrEmpty(valor) == false)

            if (string.IsNullOrEmpty(model?.Entrada) == false)
            {
                var entrada = model.Entrada;
                var texto = FormatarEntrada(entrada);
                model.Texto = texto;
                return View(model);
            }
            else
            {
                return View();
            }
        }

        private static string FormatarEntrada(string entrada)
        {
            return string.Format("Seu nome é: {0}.", entrada);
        }
    }
}