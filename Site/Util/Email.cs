using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Site.Models;
using System.Net;
using System.Net.Mail;

namespace Site.Util
{
    public class Email
    {
        public void EnviarEmail(EmailModel e)
        {
            try
            {
                
                MailMessage msg = new MailMessage(e.Conta, e.Email);
                msg.Subject = e.Assunto;
                msg.Body = e.Mensagem;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(e.Conta, e.Senha);

                smtp.Send(msg);
            }
            catch
            {
                throw;
            }
        }
    }
}