using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Site.Models;
using System.Net;
using System.Net.Mail;
using Site.Util;

namespace Site.Controllers
{
    public class EmailController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EnviaEmail(EmailModel emailModel)
        {
            try
            {
                emailModel.Smtp = "smtp.seuSite.com";
                emailModel.Porta = 587;
                emailModel.Conta = "email@seuSite.com";
                emailModel.Senha = "suaSenha";


                Email e = new Email();
                e.EnviarEmail(emailModel);

                TempData["MenssagemOk"] = " E-mail enviado !";
            }
            catch
            {
                TempData["MessagemFail"] = " Erro ao tentar enviar o e-mail !";
            }

            return RedirectToAction("Index", "Email");
        }
    }
}