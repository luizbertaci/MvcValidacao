using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcValidacao.Models;

namespace MvcValidacao.Controllers
{
    public class PessoaController : Controller
    {
      
        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View(pessoa );
        }

        [HttpPost ]
        public ActionResult Index(Pessoa pessoa) {
            //if(string.IsNullOrWhiteSpace(pessoa.Nome ))
            //{
            //    ModelState.AddModelError("Nome","O campo nome é obrigatorio.");
            //}
            //if (string.IsNullOrWhiteSpace(pessoa.Email))
            //{
            //    ModelState.AddModelError("Email", "O campo email é obrigatorio.");
            //}
            if(ModelState.IsValid )
            {
                return View("Resultado",pessoa );
            }
            
            return View( pessoa);
        
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }

    }


}
