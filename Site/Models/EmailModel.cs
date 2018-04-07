using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class EmailModel
    {
        public string Email { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
        public string Smtp { get; set; }
        public int Porta { get; set; }
        public string Conta { get; set; }
        public string Senha { get; set; }
    }
}