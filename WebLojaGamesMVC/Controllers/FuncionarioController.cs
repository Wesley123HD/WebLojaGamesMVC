using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLojaGamesMVC.Models;
using System.Collections.ObjectModel;

namespace WebLojaGamesMVC.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            Funcionario func = new Funcionario();
            return View(func);
        }
        [HttpPost]
        public ActionResult Index(Funcionario funcionario)
        {
            if(ModelState.IsValid)
            {
                return View("Listar", funcionario);
            }
            return View(funcionario);
        }
        public ActionResult Listar(Funcionario funcionario)
        {
            return View(funcionario);
        }
    }
}