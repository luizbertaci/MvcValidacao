using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.ComponentModel.DataAnnotations;

namespace MvcValidacao.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage="Nome deve ser preenchido...")]
        public string Nome { get; set; }

        [Range (18,50,ErrorMessage="Idade deve estar entre 18 e 50 anos...")]
        [Required(ErrorMessage = "Idade deve ser preenchido...")]
        public int Idade { get; set; }

        [RegularExpression("^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$", ErrorMessage="Email Invalidooo")]
        public string Email { get; set; }
    }
}