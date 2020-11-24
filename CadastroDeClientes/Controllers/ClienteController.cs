using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroDeClientes.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Cadastro()
        {
            return View();
        }
        // CADASTRO 
        [HttpPost]
        public ActionResult Cadastro(FormCollection dados)
        {
            using (var ctx = new Models.CadastroClienteEntities1())
            {
                ctx.Tab_Cliente.Add(new Models.Tab_Cliente()
                {
                    Nome_Cli = dados["txtNome_Cli"],
                    Email_Cli = dados["txtEmail_Cli"],
                    Tel_Cli = dados["txtTel_Cli"],
                    Id_Cli = int.Parse(dados["txtId_Cli"])
                
                });
                ctx.SaveChanges();
            }
            ViewBag.Mensagem = "Cadastro Efetuado";   
            return View();
        }
    }
}